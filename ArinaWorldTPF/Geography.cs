using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArinaWorld;
using Aritiafel;

namespace ArinaWorldTPF
{
    public static class Geography
    {        
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
        public static void ProducePangeaGeography(Map map)
        {
            if (map == null)
                throw new ArgumentNullException(nameof(map));
            for (long i = 0; i < map.Height; i++)
            {
                for (long j = 0; j < map.Width; j++)
                {

                }
            }
        }
    }
}
