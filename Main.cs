using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;
using System;
using GT2Bizhawk.GameVersions;

namespace GT2Bizhawk {
	[ExternalTool("GT2HybridTool", Description = "GT2 Hybrid Tool")]
	[ExternalToolApplicability.RomWhitelist(CoreSystem.Playstation,
		//"BizHash" hashes, see https://github.com/TASVideos/BizHawk/blob/master/ExternalToolProjects/DBMan/Data/psx-hash.txt
		//datahash = CRC-32 of the bin file, bizhash = what the emulator checks
		//all hashes are disc 2 (gran turismo/simulation mode)
		"D2C9B4EE", //NTSC-U 1.0
		"B5A363A3", //NTSC-U 1.1
		"E3672E95", //NTSC-U 1.2
		"20FB91D3", //NTSC-J 1.0
		"7E74A4F0", //NTSC-J 1.1
		"AFCCF4DC"  //PAL
		)]
	public sealed partial class MainForm : ToolFormBase, IExternalToolForm {
        protected override string WindowTitleStatic => "GT2 Hybrid Tool";
		[RequiredApi]
		public ApiContainer? PubApis { get; set; }
		private ApiContainer Api => PubApis!;
		private bool IsGameLoaded => Api.GameInfo.GetRomName() != "Null";
		private uint LastGarageCount = 0;
		/// <summary>
		/// Japanese versions tack on two zeroes at the end to make the money look like yen
		/// </summary>
		private bool GameIsJapanese = false;
		private IBaseGameVersion GameVer { get; set; }

#pragma warning disable CS8618
        public MainForm() {
            InitializeComponent();
        }
#pragma warning restore CS8618

		/// <summary>
		/// Returns game version from the game's hash
		/// </summary>
		/// <param name="hash">Game's hash</param>
		/// <returns>Tuple: (region, version)</returns>
		private (string, string) VersionFromHash(string hash) {
			switch (hash) {
				case "D2C9B4EE": //NTSC-U 1.0
					return ("NTSC-U", "1.0");
				case "B5A363A3": //NTSC-U 1.1
					return ("NTSC-U", "1.1");
				case "E3672E95": //NTSC-U 1.2
					return ("NTSC-U", "1.2");
				case "20FB91D3": //NTSC-J 1.0
					return ("NTSC-J", "1.0");
				case "7E74A4F0": //NTSC-J 1.1
					return ("NTSC-J", "1.1");
				case "AFCCF4DC": //PAL
					return ("PAL", "1.0"); //are there multiple PAL versions?

				default:
					throw new NotImplementedException("Unknown hash.");
			}
        }

		private void GarageTabUpdate(bool force = false) {
			uint curGarageCount = Api.Memory.ReadU32(GameVer.GarageSize);
			if (LastGarageCount == curGarageCount && !force)
				return;

			GarageListView.BeginUpdate();
			GarageListView.Items.Clear();
			//cars are 0xa4 bytes long
			for (uint i = 0; i < (curGarageCount * 0xa4); i += 0xa4) {
				uint carStart = GameVer.GarageStart + i;
				uint carCode = Api.Memory.ReadU32(carStart);
				GarageListView.Items.Add($"{carCode:X8}");
            }
			GarageListView.EndUpdate();
			LastGarageCount = curGarageCount;
		}
        
		public override void Restart() {
			var v = VersionFromHash(Api.GameInfo.GetRomHash());
			DetectedGameLbl.Text = $"Detected {v.Item1} version {v.Item2}";

			//enabling japanese formatting for money
			if (v.Item1 == "NTSC-J")
				GameIsJapanese = true;
			else
				GameIsJapanese = false;

			//loading version specific addresses
			switch (v) {
				case ("NTSC-U", "1.2"): {
					GameVer = new NtscU12();
					break;
                }

				case ("NTSC-J", "1.1"): {
					GameVer = new NtscJ11();
					break;
                }

				default:
					throw new NotImplementedException("Unsupported version");
			}
		}

		protected override void UpdateAfter() {
			if (!IsGameLoaded)
				return;

			switch (MainTabControl.SelectedIndex) {
				//Game tab
				case 0: {
					//Money
					ulong money = Api.Memory.ReadU32(GameVer.Money);
					if (GameIsJapanese)
						money *= 100;

					GameListView.Items[0].SubItems[1].Text = $"{money:N0}";

					GameListView.Items[1].SubItems[1].Text = $"{Api.Memory.ReadS32(GameVer.Days):N0}"; //Days

					//Current Car
					uint currentCar = Api.Memory.ReadU32(GameVer.CurrentCar);
					if (currentCar == 0xffff)
						GameListView.Items[2].SubItems[1].Text = "N/A";
					else
						GameListView.Items[2].SubItems[1].Text = $"{currentCar}";
					
					GameListView.Items[3].SubItems[1].Text = $"{Api.Memory.ReadU32(GameVer.GarageSize):N0}"; //Garage Size

					break;
				}

				//Garage tab
				case 1: {
					GarageTabUpdate();
					break;
                }
				
				default: {
					return;
                }
			}
		}

        private void MaxMoneyBtn_Click(object sender, System.EventArgs e) {
			if (IsGameLoaded)
				Api.Memory.WriteU32(GameVer.Money, 99999999);
		}

        private void GotoCar1Btn_Click(object sender, System.EventArgs e) {
			if (IsGameLoaded)
				Api.Memory.WriteU32(GameVer.CurrentCar, 0);
		}

        private void MainTabControl_SelectedIndexChanged(object sender, System.EventArgs e) {
			if (IsGameLoaded)
				switch (MainTabControl.SelectedIndex) {
					case 1: {
						GarageTabUpdate();
						break;
					}

					default: {
						return;
					}
				}
		}

        private void CarEditBtn_Click(object sender, EventArgs e) {
			if (!IsGameLoaded)
				return;


        }
    }
}
