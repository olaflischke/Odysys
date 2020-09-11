using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EierfarmBl
{
    public interface IEiLeger
    {
        List<Ei> Eier { get; set; }
        double Gewicht { get; set; }

        void EiLegen();
        void Fressen();
    }
}