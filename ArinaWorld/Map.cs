using System;

namespace ArinaWorld
{
    public class Map
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Province> Provinces { get; set; } = new List<Province>();
        public Grid[,]? Grids { get; set; }

        public Map(string name, int width, int height)
        {
            Name = name;
            Width = width;
            Height = height;
            Grids = new Grid[width, height];
            for(int i = 0; i < width; i++)
                for(int j = 0; j < height; j++)
                    Grids[i, j] = new Grid();
        }
    }
}