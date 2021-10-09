using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;
using System.Windows.Forms;

namespace GT2Bizhawk {
	[ExternalTool("GT2HybridTool", Description = "GT2 Hybrid Tool")]
	public sealed partial class MainForm : ToolFormBase, IExternalToolForm {
        protected override string WindowTitleStatic => "GT2 Hybrid Tool";
		[RequiredApi]
		public ApiContainer PubApis { get; set; }
		private ApiContainer Api => PubApis!;
		private bool IsGameLoaded => Api.GameInfo.GetRomName() != "Null";
		private uint LastGarageCount = 0;

		public MainForm() {
			//winforms stuff
			InitializeComponent();
        }

		private void GarageTabUpdate(bool force = false) {
			uint curGarageCount = Api.Memory.ReadU32(0x1cd554);
			if (LastGarageCount == curGarageCount && !force)
				return;

			GarageListView.BeginUpdate();
			GarageListView.Items.Clear();
			//cars are 0xa4 bytes long
			for (uint i = 0; i < (curGarageCount * 0xa4); i += 0xa4) {
				uint carStart = 0x1cd558 + i;
				uint carCode = Api.Memory.ReadU32(carStart);
				GarageListView.Items.Add($"{carCode:X8}");
            }
			GarageListView.EndUpdate();
			LastGarageCount = curGarageCount;
		}
        
		public override void Restart() {
			string? romName = Api.GameInfo.GetRomName();
			if (romName != "Null") {
				DetectedGameLbl.Text = "Detected Game: " + romName;
            }
		}

		protected override void UpdateAfter() {
			if (!IsGameLoaded)
				return;

			switch (MainTabControl.SelectedIndex) {
				//Game tab
				case 0: {
					GameListView.Items[0].SubItems[1].Text = $"{Api.Memory.ReadU32(0x1d1568):N0}"; //Money
					GameListView.Items[1].SubItems[1].Text = $"{Api.Memory.ReadS32(0x1c99d8):N0}"; //Days

					//Current Car
					uint currentCar = Api.Memory.ReadU32(0x1d156c);
					if (currentCar == 0xffff)
						GameListView.Items[2].SubItems[1].Text = "N/A";
					else
						GameListView.Items[2].SubItems[1].Text = $"{currentCar}";
					
					GameListView.Items[3].SubItems[1].Text = $"{Api.Memory.ReadU32(0x1cd554):N0}"; //Garage Size

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
				Api.Memory.WriteU32(0x1d1568, 99999999);
		}

        private void GotoCar1Btn_Click(object sender, System.EventArgs e) {
			if (IsGameLoaded)
				Api.Memory.WriteU32(0x1d156c, 0);
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
    }
}
