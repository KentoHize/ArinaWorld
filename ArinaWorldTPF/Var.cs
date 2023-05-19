﻿using System;
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

        public static string CustomDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Arina World");
    }
}
