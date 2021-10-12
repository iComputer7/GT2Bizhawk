namespace GT2Bizhawk.GameVersions {
    public interface IBaseGameVersion {
        public string GameHash { get; }
        public uint GarageStart { get; }
        public uint Money { get; }
        public uint Days { get; }
        public uint CurrentCar { get; }
        public uint GarageSize { get; }
    }
}
