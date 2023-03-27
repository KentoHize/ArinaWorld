using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArinaWorld
{
    public class Province
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public List<Province> ContiguousProvinces { get; set; } = new List<Province>();
    }
}
