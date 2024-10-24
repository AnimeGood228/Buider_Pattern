using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buider_Pattern.Сomponents
{
    public class Motherboard
    {
        public string Model { get; set; }
        public string FormFactor { get; set; }

        public Motherboard(string model, string formFactor)
        {
            Model = model;
            FormFactor = formFactor;
        }
    }
}
