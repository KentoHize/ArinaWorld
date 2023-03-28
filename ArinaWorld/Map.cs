using System;

namespace ArinaWorld
{
    public class Map
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }
        public List<Province> Provinces { get; set; } = new List<Province>();
    }
}