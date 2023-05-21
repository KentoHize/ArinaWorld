using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ArinaWorld;
using Aritiafel.Artifacts;
using Aritiafel.Organizations.ArinaOrganization;
using GameData;

namespace ArinaWorldTPF
{
    public static class Geography
    {
        public static Dictionary<string, int>? Terrains { get; set; }
        public static Dictionary<string, int>? SurfaceFeatures { get; set; }
        public static Dictionary<string, int>? NatureImprovements { get; set; }      

        public static void LoadRelatedData()
        {
            Terrains = new Dictionary<string, int>();
            SurfaceFeatures = new Dictionary<string, int>();
            NatureImprovements = new Dictionary<string, int>();
            //using (StreamReader sr = new StreamReader(Path.Combine(Const.DataPath, "Geography", "Terrain.json")))
            using (StreamReader sr = new StreamReader(Path.Combine(Const.GameDataPath, "Terrain.json")))
            {
                Terrain[]? ts = JsonSerializer.Deserialize<Terrain[]>(sr.ReadToEnd());
                foreach (Terrain t in ts)
                    Terrains.Add(t.Name, t.ID);
            }

            using (StreamReader sr = new StreamReader(Path.Combine(Const.GameDataPath, "SurfaceFeature.json")))
            {
                SurfaceFeature[]? sfs = JsonSerializer.Deserialize<SurfaceFeature[]>(sr.ReadToEnd());
                foreach (SurfaceFeature sf in sfs)
                    SurfaceFeatures.Add(sf.Name, sf.ID);
            }

            using (StreamReader sr = new StreamReader(Path.Combine(Const.GameDataPath, "NatureImprovement.json")))
            {
                NatureImprovement[]? nis = JsonSerializer.Deserialize<NatureImprovement[]>(sr.ReadToEnd());
                foreach (NatureImprovement ni in nis)
                    NatureImprovements.Add(ni.Name, ni.ID);
            }
        }

        private static Grid[] GetAdjacencyGrid(Map map, Grid grid, bool includeOblique = true)
        {
            List<Grid> result = new List<Grid>();
            //Edge Grid
            if (grid.X == 0 || grid.Y == 0 || grid.X == map.Width - 1 || grid.Y == map.Height - 1)
            {
                if (grid.X - 1 >= 0)
                {
                    result.Add(map.Grids[grid.X - 1, grid.Y]);
                    if (grid.Y + 1 < map.Height)
                        result.Add(map.Grids[grid.X - 1, grid.Y + 1]);
                    if (grid.Y - 1 >= 0)
                        result.Add(map.Grids[grid.X - 1, grid.Y - 1]);
                }
                if (grid.X + 1 < map.Width)
                {
                    result.Add(map.Grids[grid.X + 1, grid.Y]);
                    if (grid.Y + 1 < map.Height)
                        result.Add(map.Grids[grid.X + 1, grid.Y + 1]);
                    if (grid.Y - 1 >= 0)
                        result.Add(map.Grids[grid.X + 1, grid.Y - 1]);
                }
                if (grid.Y + 1 < map.Height)
                    result.Add(map.Grids[grid.X, grid.Y + 1]);
                if (grid.Y - 1 >= 0)
                    result.Add(map.Grids[grid.X, grid.Y - 1]);
            }
            else
            {
                result.Add(map.Grids[grid.X - 1, grid.Y - 1]);
                result.Add(map.Grids[grid.X - 1, grid.Y]);
                result.Add(map.Grids[grid.X - 1, grid.Y + 1]);
                result.Add(map.Grids[grid.X + 1, grid.Y]);
                result.Add(map.Grids[grid.X + 1, grid.Y + 1]);
                result.Add(map.Grids[grid.X + 1, grid.Y - 1]);
                result.Add(map.Grids[grid.X, grid.Y - 1]);
                result.Add(map.Grids[grid.X, grid.Y + 1]);
            }
            return result.ToArray();
        }

        public static void GridExpand(Map map, Grid[] grids, int peakAltitude, ushort declineInterval = 100)
        {
            if (peakAltitude < 0)
                return;
            if (grids == null)
                return;
            List<Grid> allgrids = new List<Grid>();
            for (int i = 0; i < grids.Length; i++)
            {
                if (grids[i].Altitude < peakAltitude)
                {
                    grids[i].Altitude = peakAltitude;                    
                    grids[i].SurfaceFeature = SurfaceFeatures["Grass"];                    
                    Grid[] agrid = GetAdjacencyGrid(map, grids[i]);
                    for(int j = 0; j < agrid.Length; j++)
                    {
                        if (agrid[j].Altitude < peakAltitude - declineInterval)
                            allgrids.Add(agrid[j]);
                    }
                }
            }
            for(int i = 0; i < allgrids.Count; i++)
                GridExpand(map, allgrids.ToArray(), peakAltitude - declineInterval, declineInterval);            
        }
        public static void ProducePangeaGeography(Map map, int height, int width,
            int avergeHumidity, CompassDirection coldDirection, int lowTemperature,
            int highTemperature, TwoWayCompassDirection extrusionDirection, int peakAltitude)
        {
            if (map == null)
                throw new ArgumentNullException(nameof(map));

            //大小
            //濕度
            //溫度
            //擠壓方向
            map.Grids = new Grid[map.Width, map.Height];
            for (long i = 0; i < map.Width; i++)
            {

                for (long j = 0; j < map.Height; j++)
                {
                    map.Grids[i, j] = new Grid
                    {
                        Altitude = 10,
                        Terrain = Terrains["Sea"],
                        SurfaceFeature = SurfaceFeatures["Sea"],
                        X = i,
                        Y = j

                    };

                    //隨機高度 隨機點
                   

                }
            }
            ChaosBox cb = new ChaosBox();
            for(int i = 0; i < 10; i++)
            {
                int w = cb.DrawOutInteger(1, (int)map.Width - 1);
                int h = cb.DrawOutInteger(1, (int)map.Height - 1);                
                GridExpand(map, new Grid[] { map.Grids[w, h] }, peakAltitude);
            }
            
            //peakAltitude 
            //peakAltitude
            //擠壓的高度決定擠壓的間隔長度
            //高度-> 最高山8850m
            //普通山600m以上
            //最深海溝 10860m
            //降速大約是100m/格
            //假設有1000m山脈，至少要距離20格左右才能第二座山脈線
            //20以上
            //Random r;
        }
    }
}
