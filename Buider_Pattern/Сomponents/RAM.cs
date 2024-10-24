using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buider_Pattern.Сomponents
{
    public class RAM
    {
        public string Model { get; set; }
        public int SizeGB { get; set; }

        public RAM(string model, int sizeGB)
        {
            Model = model;
            SizeGB = sizeGB;
        }
    }
}
