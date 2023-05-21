using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArinaWorldTPF
{
    public static class Setting
    {
        public static int RotateAngleZ { get; set; } = 0;
        public static int RotateAngleY { get; set; } = 0;
        public static int TransformX { get; set; } = 0;
        public static int TransformY { get; set; } = 0;
        public static int AmplificationFactor { get; set; } = 50;
        public static CultureInfo CultureInfo { get; set; } = new CultureInfo("en-US");

        public static int DefaultMapWidth { get; set; } = 300;
        public static int DefaultMapHeight { get; set; } = 300;
        //public static string DefaultMapName { get; set; } = "新地圖";
    }
}
