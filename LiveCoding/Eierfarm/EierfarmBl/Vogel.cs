using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EierfarmBl
{
    public abstract class Vogel : IEiLeger
    {
        public List<Ei> Eier { get; set; } = new List<Ei>();

        public double Gewicht { get; set; }
        public string Name { get; set; }

        public abstract void EiLegen();

        public abstract void Fressen();
    }
}