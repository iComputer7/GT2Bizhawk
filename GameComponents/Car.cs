using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GT2Bizhawk.GameComponents {
    /// <summary>
    /// Class for car related things.
    /// </summary>
    /// <remarks>Most info from Pupik's GT2 Spot. Credit to FormulaNone.</remarks>
    public class Car {
        //yes i indeed typed all of this out by hand

        /// <summary>
        /// Car Code
        /// </summary>
        /// <remarks>Values are mostly the same as body codes AFAIK</remarks>
        public uint CarCode { get; set; }

        #region Appearance

        /// <summary>
        /// Color Code
        /// </summary>
        public uint ColorCode { get; set; }
        /// <summary>
        /// Body Code
        /// </summary>
        public uint BodyCode { get; set; }
        /// <summary>
        /// Value > 1 means that you can get a car wash?
        /// </summary>
        public ushort Cleanliness { get; set; }

        #endregion

        #region Parts

        /// <summary>
        /// Rims code
        /// </summary>
        /// <remarks>Item1 = Code 1 and 2, Item2 = Code 3</remarks>
        public (uint, ushort) RimsCode { get; set; } = (0, 0);
        /// <summary>
        /// Brakes
        /// </summary>
        public ushort Brakes { get; set; }
        /// <summary>
        /// Brake Controller
        /// </summary>
        public ushort BrakeController { get; set; }
        /// <summary>
        /// Base Weight
        /// </summary>
        /// <remarks>Is a part code, not an actual number</remarks>
        public ushort BaseWeight { get; set; }
        /// <summary>
        /// Engine
        /// </summary>
        public ushort Engine { get; set; }
        /// <summary>
        /// Drivetrain
        /// </summary>
        /// <remarks>Part code</remarks>
        public ushort Drivetrain { get; set; }
        /// <summary>
        /// Transmission
        /// </summary>
        public ushort Transmission { get; set; }
        /// <summary>
        /// Suspension
        /// </summary>
        public ushort Suspension { get; set; }
        /// <summary>
        /// Differential
        /// </summary>
        public ushort Differential { get; set; }
        /// <summary>
        /// Front Tires
        /// </summary>
        public ushort FrontTires { get; set; }
        /// <summary>
        /// Rear Tires
        /// </summary>
        public ushort RearTires { get; set; }
        /// <summary>
        /// Weight Reduction
        /// </summary>
        public ushort WeightReduction { get; set; }
        /// <summary>
        /// Weight Distribution
        /// </summary>
        public ushort WeightDistribution { get; set; }
        /// <summary>
        /// Port and Polish
        /// </summary>
        public ushort PortPolish { get; set; }
        /// <summary>
        /// Engine Balancing
        /// </summary>
        public ushort EngineBalance { get; set; }
        /// <summary>
        /// Displacement
        /// </summary>
        /// <remarks>Part code</remarks>
        public ushort Displacement { get; set; }
        /// <summary>
        /// Engine ROM Chip
        /// </summary>
        public ushort EngineRomChip { get; set; }
        /// <summary>
        /// NA Tuning
        /// </summary>
        public ushort NATuning { get; set; }
        /// <summary>
        /// Turbocharger
        /// </summary>
        public ushort Turbocharger { get; set; }
        /// <summary>
        /// Flywheel
        /// </summary>
        public ushort Flywheel { get; set; }
        /// <summary>
        /// Clutch
        /// </summary>
        public ushort Clutch { get; set; }
        /// <summary>
        /// Driveshaft
        /// </summary>
        public ushort Driveshaft { get; set; }
        /// <summary>
        /// Exhaust/Muffler
        /// </summary>
        public ushort Exhaust { get; set; }
        /// <summary>
        /// Intercooler
        /// </summary>
        public ushort Intercooler { get; set; }
        /// <summary>
        /// Active Stability Control
        /// </summary>
        public ushort Asc { get; set; }
        /// <summary>
        /// Traction Control System
        /// </summary>
        public ushort Tcs { get; set; }
        /// <summary>
        /// Turbo Blowoff Sound
        /// </summary>
        public ushort TurboBlowoff { get; set; }
        /// <summary>
        /// Turbo Boost Gauge
        /// </summary>
        public ushort TurboGauge { get; set; }

        #endregion

        #region Gear Ratios

        /// <summary>
        /// Reverse Gear Ratio
        /// </summary>
        /// <remarks>Stored as UInt16, divide by 100 to get the ratio</remarks>
        public ushort ReverseGear { get; set; }
        /// <summary>
        /// 1st Gear Ratio
        /// </summary>
        /// <remarks>Stored as UInt16, divide by 100 to get the ratio</remarks>
        public ushort FirstGear { get; set; }
        /// <summary>
        /// 2nd Gear Ratio
        /// </summary>
        /// <remarks>Stored as UInt16, divide by 100 to get the ratio</remarks>
        public ushort SecondGear { get; set; }
        /// <summary>
        /// 3rd Gear Ratio
        /// </summary>
        /// <remarks>Stored as UInt16, divide by 100 to get the ratio</remarks>
        public ushort ThirdGear { get; set; }
        /// <summary>
        /// 4th Gear Ratio
        /// </summary>
        /// <remarks>Stored as UInt16, divide by 100 to get the ratio</remarks>
        public ushort FourthGear { get; set; }
        /// <summary>
        /// 5th Gear Ratio
        /// </summary>
        /// <remarks>Stored as UInt16, divide by 100 to get the ratio</remarks>
        public ushort FifthGear { get; set; }
        /// <summary>
        /// 6th Gear Ratio
        /// </summary>
        /// <remarks>Stored as UInt16, divide by 100 to get the ratio</remarks>
        public ushort SixthGear { get; set; }
        /// <summary>
        /// 7th Gear Ratio
        /// </summary>
        /// <remarks>Stored as UInt16, divide by 100 to get the ratio</remarks>
        public ushort SeventhGear { get; set; }
        /// <summary>
        /// Final Drive/Gear
        /// </summary>
        /// <remarks>Actually a differential setting but is roped in with the transmission</remarks>
        public ushort FinalDrive { get; set; }
        /// <summary>
        /// Auto Gearing
        /// </summary>
        /// <remarks>Controls how the game automatically sets gear ratios for you</remarks>
        public ushort AutoGearing { get; set; }

        #endregion

        #region Suspension Settings

        /// <summary>
        /// Camber Angle
        /// </summary>
        public ushort Camber { get; set; }
        /// <summary>
        /// Ride Height
        /// </summary>
        public ushort RideHeight { get; set; }
        /// <summary>
        /// Toe Angle
        /// </summary>
        public ushort Toe { get; set; }
        /// <summary>
        /// Spring Rate
        /// </summary>
        public ushort SpringRate { get; set; }
        /// <summary>
        /// Seems to be a hidden suspension value?
        /// </summary>
        public ushort TractionSuspension { get; set; }
        /// <summary>
        /// Front damper: Item1 = Bound, Item2 = Rebound
        /// </summary>
        public (ushort, ushort) FrontDamper { get; set; } = (0, 0);
        /// <summary>
        /// Rear damper: Item1 = Bound, Item2 = Rebound
        /// </summary>
        public (ushort, ushort) RearDamper { get; set; } = (0, 0);
        /// <summary>
        /// Stabilizer (Suspension)
        /// </summary>
        public ushort Stabilizer { get; set; }

        #endregion

        #region Unknown Fields

        /// <summary>
        /// Unknown field at address 0x1ccfc8 on NTSC-U v1.0
        /// </summary>
        public ushort Unknown1ccfc8 { get; set; }
        /// <summary>
        /// Unknown field at 0x1cd018 on NTSC-U v1.0
        /// </summary>
        public ushort Unknown1cd018 { get; set; }
        /// <summary>
        /// Unknown field at 0x1cd036 on NTSC-U v1.0
        /// </summary>
        public ushort Unknown1cd036 { get; set; }
        /// <summary>
        /// Unknown field at 0x1cd03a on NTSC-U v1.0
        /// </summary>
        public ushort Unknown1cd03a { get; set; }
        /// <summary>
        /// Unknown field at 0x1cd03c on NTSC-U v1.0
        /// </summary>
        public ushort Unknown1cd03c { get; set; }
        /// <summary>
        /// Unknown field at 0x1cd03e on NTSC-U v1.0
        /// </summary>
        public ushort Unknown1cd03e { get; set; }
        /// <summary>
        /// Unknown field at 0x1cd040 on NTSC-U v1.0
        /// </summary>
        public ushort Unknown1cd040 { get; set; }
        /// <summary>
        /// Unknown field at 0x1cd042 on NTSC-U v1.0
        /// </summary>
        public ushort Unknown1cd042 { get; set; }

        #endregion

        #region Misc Fields/Settings

        /// <summary>
        /// Power Multiplier
        /// </summary>
        /// <remarks>I have no idea</remarks>
        public ushort PowerMultiplier { get; set; }
        /// <summary>
        /// Brake Control Settings
        /// </summary>
        public ushort BrakeControlSettings { get; set; }
        /// <summary>
        /// Downforce
        /// </summary>
        /// <remarks>Item1 = Front, Item2 = Rear</remarks>
        public (byte, byte) Downforce { get; set; } = (0, 0);
        /// <summary>
        /// LSD Yaw
        /// </summary>
        public ushort LsdYaw { get; set; }
        /// <summary>
        /// LSD Accel
        /// </summary>
        public ushort LsdAccel { get; set; }
        /// <summary>
        /// LSD Decel
        /// </summary>
        public ushort LsdDecel { get; set; }
        /// <summary>
        /// ASC+TCS Settings
        /// </summary>
        public ushort AscTcsSettings { get; set; }
        /// <summary>
        /// Parts Dealership, which dealership lets you upgrade this car
        /// </summary>
        public ushort PartsDealership { get; set; }
        /// <summary>
        /// Car Price
        /// </summary>
        /// <remarks>Actual integer value</remarks>
        public uint CarPrice { get; set; }
        /// <summary>
        /// Labeled as Weight - Drivetrain in hybrid basecodes
        /// </summary>
        public ushort WeightDrivetrain { get; set; }
        /// <summary>
        /// Torque
        /// </summary>
        /// <remarks>No idea</remarks>
        public ushort Torque { get; set; }
        /// <summary>
        /// Labeled as HP - [R] - Auto in hybrid basecodes
        /// </summary>
        public ushort HP_R_Auto { get; set; }
        /// <summary>
        /// Labeled as Fitments 1 thru 4 in hybrid basecodes
        /// </summary>
        /// <remarks>Item# = Fitments #</remarks>
        public (ushort, ushort, ushort, ushort) Fitments { get; set; } = (0, 0, 0, 0);

        #endregion

        /// <summary>
        /// Creates an instance of the Car class.
        /// </summary>
        /// <param name="_carRaw">Raw memory data of this car</param>
        public Car(byte[] _carRaw) {
            if (_carRaw.Length != 0xa4)
                throw new Exception($"Given raw car value is not the right size. Got 0x{_carRaw.Length:x2} bytes, expected 0xa4 bytes.");

            //converting byte array into memorystream, then into binaryreader
            BinaryReader rawCar = new(new MemoryStream(_carRaw));

            //reading values out of the stream and into the class
            CarCode = rawCar.ReadUInt32();
            ColorCode = rawCar.ReadUInt32();
            uint _rims1 = rawCar.ReadUInt32();
            Brakes = rawCar.ReadUInt16();
            BrakeController = rawCar.ReadUInt16();
            Unknown1ccfc8 = rawCar.ReadUInt16();
            BaseWeight = rawCar.ReadUInt16();
            Engine = rawCar.ReadUInt16();
            Drivetrain = rawCar.ReadUInt16();
            Transmission = rawCar.ReadUInt16();
            Suspension = rawCar.ReadUInt16();
            Differential = rawCar.ReadUInt16();
            FrontTires = rawCar.ReadUInt16();
            RearTires = rawCar.ReadUInt16();
            WeightReduction = rawCar.ReadUInt16();
            WeightDistribution = rawCar.ReadUInt16();
            PortPolish = rawCar.ReadUInt16();
            EngineBalance = rawCar.ReadUInt16();
            Displacement = rawCar.ReadUInt16();
            EngineRomChip = rawCar.ReadUInt16();
            NATuning = rawCar.ReadUInt16();
            Turbocharger = rawCar.ReadUInt16();
            Flywheel = rawCar.ReadUInt16();
            Clutch = rawCar.ReadUInt16();
            Driveshaft = rawCar.ReadUInt16();
            Exhaust = rawCar.ReadUInt16();
            Intercooler = rawCar.ReadUInt16();
            Asc = rawCar.ReadUInt16();
            Tcs = rawCar.ReadUInt16();
            ushort _rims2 = rawCar.ReadUInt16();
            PowerMultiplier = rawCar.ReadUInt16();
            ReverseGear = rawCar.ReadUInt16();
            FirstGear = rawCar.ReadUInt16();
            SecondGear = rawCar.ReadUInt16();
            ThirdGear = rawCar.ReadUInt16();
            FourthGear = rawCar.ReadUInt16();
            FifthGear = rawCar.ReadUInt16();
            SixthGear = rawCar.ReadUInt16();
            SeventhGear = rawCar.ReadUInt16();
            FinalDrive = rawCar.ReadUInt16();
            AutoGearing = rawCar.ReadUInt16();
            BrakeControlSettings = rawCar.ReadUInt16();
            byte _downfront = rawCar.ReadByte();
            byte _downrear = rawCar.ReadByte();
            TurboBlowoff = rawCar.ReadUInt16();
            TurboGauge = rawCar.ReadUInt16();
            Unknown1cd018 = rawCar.ReadUInt16();
            Camber = rawCar.ReadUInt16();
            RideHeight = rawCar.ReadUInt16();
            Toe = rawCar.ReadUInt16();
            SpringRate = rawCar.ReadUInt16();
            TractionSuspension = rawCar.ReadUInt16();
            byte _fbound = rawCar.ReadByte();
            byte _frebound = rawCar.ReadByte();
            byte _rbound = rawCar.ReadByte();
            byte _rrebound = rawCar.ReadByte();
            Stabilizer = rawCar.ReadUInt16();
            LsdYaw = rawCar.ReadUInt16();
            LsdAccel = rawCar.ReadUInt16();
            LsdDecel = rawCar.ReadUInt16();
            AscTcsSettings = rawCar.ReadUInt16();
            Unknown1cd036 = rawCar.ReadUInt16();
            Unknown1cd03a = rawCar.ReadUInt16();
            Unknown1cd03c = rawCar.ReadUInt16();
            Unknown1cd03e = rawCar.ReadUInt16();
            Unknown1cd040 = rawCar.ReadUInt16();
            Unknown1cd042 = rawCar.ReadUInt16();
            BodyCode = rawCar.ReadUInt32();
            CarPrice = rawCar.ReadUInt32();
            WeightDrivetrain = rawCar.ReadUInt16();
            Torque = rawCar.ReadUInt16();
            HP_R_Auto = rawCar.ReadUInt16();
            ushort _fit1 = rawCar.ReadUInt16();
            ushort _fit2 = rawCar.ReadUInt16();
            ushort _fit3 = rawCar.ReadUInt16();
            ushort _fit4 = rawCar.ReadUInt16();
            Cleanliness = rawCar.ReadUInt16();

            Fitments = (_fit1, _fit2, _fit3, _fit4);
            FrontDamper = (_fbound, _frebound);
            RearDamper = (_rbound, _rrebound);
            Downforce = (_downfront, _downrear);
            RimsCode = (_rims1, _rims2);
        }
    }
}
