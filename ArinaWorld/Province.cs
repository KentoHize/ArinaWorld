using System;

namespace ArinaWorld
{
    public class Province
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public long X { get; set; }
        public long Y { get; set; }
        public int AverageTemperature { get; set; }

        public List<Grid> Grid { get; set; } = new List<Grid>();

        //public List<Province> ContiguousProvinces { get; set; } = new List<Province>();
    }
}