using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ArinaWorld;
using Aritiafel.Items;

namespace ArinaWorldTPF
{
    public static class Var
    {
        public static Map? Map { get; set; }
        public static MapForm? MapForm { get; set; }
        public static Point SelectedBlock { get; set; }
        public static int TransformX { get; set; } = 0;
        public static int TransformY { get; set; } = 0;
        public static int RotateAngleY { get; set; } = 0;
        public static int RotateAngleZ { get; set; } = 0;

        public static BufferedGraphics bufferGraphics { get; set; }

        public static bool DrawBuffer { get; set; } = false;

        public static string CustomDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Arina World");
    }
}
