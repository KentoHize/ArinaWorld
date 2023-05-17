using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ArinaWorld;
using Aritiafel;

namespace ArinaWorldTPF
{
    public static class Geography
    {
        static Dictionary<string, int> terrains;
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

        public static void LoadTerrains()
        {
            terrains = new Dictionary<string, int>();
            using (StreamReader sr = new StreamReader(Path.Combine(Const.DataPath, "Geography", "Terrain.json")))
            {
                Terrain[]? ts = JsonSerializer.Deserialize<Terrain[]>(sr.ReadToEnd());
                foreach (Terrain t in ts)
                    terrains.Add(t.Name, t.ID);
            }
        }
        public static void ProducePangeaGeography(Map map)
        {
            if (map == null)
                throw new ArgumentNullException(nameof(map));

            LoadTerrains();
            
            for (long i = 0; i < map.Height; i++)
            {
                for (long j = 0; j < map.Width; j++)
                {

                }
            }
        }
    }
}
