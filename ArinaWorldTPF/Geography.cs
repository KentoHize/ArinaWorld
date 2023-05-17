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
        static Dictionary<string, int> terrains;
        static Dictionary<string, int> surfaceFeatures;
        static Dictionary<string, int> natureImprovements;
        
        //public static void ProduceContinentGeography(Map map)
        //{
        //    if(map == null)
        //        throw new ArgumentNullException(nameof(map));
        //    for(long i = 0; i < map.Height; i++)
        //    {
        //        for (long j = 0; j < map.Width; j++)
        //        {
        //        }
        //    }
        //}

        public static void LoadRelatedData()
        {
            terrains = new Dictionary<string, int>();
            surfaceFeatures = new Dictionary<string, int>();
            natureImprovements = new Dictionary<string, int>();
            //using (StreamReader sr = new StreamReader(Path.Combine(Const.DataPath, "Geography", "Terrain.json")))
            using (StreamReader sr = new StreamReader(Path.Combine(Const.GameDataPath, "Terrain.json")))
            {
                Terrain[]? ts = JsonSerializer.Deserialize<Terrain[]>(sr.ReadToEnd());
                foreach (Terrain t in ts)
                    terrains.Add(t.Name, t.ID);
            }

            using (StreamReader sr = new StreamReader(Path.Combine(Const.GameDataPath, "SurfaceFeature.json")))
            {
                SurfaceFeature[]? sfs = JsonSerializer.Deserialize<SurfaceFeature[]>(sr.ReadToEnd());
                foreach (SurfaceFeature sf in sfs)
                    surfaceFeatures.Add(sf.Name, sf.ID);
            }

            using (StreamReader sr = new StreamReader(Path.Combine(Const.GameDataPath, "NatureImprovement.json")))
            {
                NatureImprovement[]? nis = JsonSerializer.Deserialize<NatureImprovement[]>(sr.ReadToEnd());
                foreach (NatureImprovement ni in nis)
                    natureImprovements.Add(ni.Name, ni.ID);
            }
        }
        public static void ProducePangeaGeography(Map map, int height, int width, 
            int avergeHumidity, CompassDirection coldDirection, int lowTemperature, 
            int highTemperature, TwoWayCompassDirection extrusionDirection, int peakAltitude)
        {
            if (map == null)
                throw new ArgumentNullException(nameof(map));

            LoadRelatedData();
            
            //大小
            //濕度
            //溫度
            //擠壓方向
            for (long i = 0; i < map.Height; i++)
            {
                for (long j = 0; j < map.Width; j++)
                {

                }
            }
        }
    }
}
