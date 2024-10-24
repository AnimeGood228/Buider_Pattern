using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buider_Pattern.Сomponents
{
    public class GPU
    {
        public string Model { get; set; }
        public int VRAM { get; set; } 

        public GPU(string model, int vram)
        {
            Model = model;
            VRAM = vram;
        }
    }
}
