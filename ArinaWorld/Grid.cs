using System;

namespace ArinaWorld
{
    public class Grid
    {
        public long X { get; set; }
        public long Y { get; set; }
        public Province Owner { get; set; }
        public long Altitude { get; set; }
        public int Terrain { get; set; }
        public int SurfaceFeature { get; set; }
        public int NatureImprovement { get; set; }
        public int Resource1 { get; set; }
        public int Resource1Quantity { get; set; }
        public int Resource2 { get; set; }
        public int Resource2Quantity { get; set; }
    }
}