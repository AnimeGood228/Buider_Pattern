using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buider_Pattern.Сomponents
{
    public class Storage
    {
        public string Type { get; set; } 
        public int SizeGB { get; set; }

        public Storage(string type, int sizeGB)
        {
            Type = type;
            SizeGB = sizeGB;
        }
    }
}
