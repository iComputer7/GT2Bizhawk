namespace GT2Bizhawk.GameVersions {
    public abstract class BaseGameVersion {
        public static string GameHash { get; } = "00000000";
        public static uint GarageCount { get; }
        public static uint GarageStart { get; }
        public static uint Money { get; }
        public static uint Days { get; }
        public static uint CurrentCar { get; }
        public static uint GarageSize { get; }
    }
}
