using System;

namespace GameData
{
    public class SurfaceFeature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int LowTemperature { get; set; }
        public int HighTemperature { get; set; }
        public int LowHumidity { get; set; }
        public int HighHumidity { get; set; }
    }
}