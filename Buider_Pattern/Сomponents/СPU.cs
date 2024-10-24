using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buider_Pattern.Сomponents
{
    public class CPU
    {
        public string Model { get; set; }
        public int Cores { get; set; }

        public CPU(string model, int cores)
        {
            Model = model;
            Cores = cores;
        }
    }
}
