using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ArinaWorld;

namespace ArinaWorldTPF
{
    public static class Var
    {
        public static Map? Map { get; set; }

        public static int RotateAngleZ { get; set; } = 0;
        public static int RotateAngleY { get; set; } = 0;
        public static int AmplificationFactor { get; set; } = 50;
    }
}
