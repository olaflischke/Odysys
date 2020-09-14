using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    class Ente : Gefluegel
    {
        public Ente(string name) : base(name)
        {
            this.Gewicht = 1000;
        }

        public override void EiLegen()
        {
            if (this.Gewicht > 1250)
            {
                Ei ei = new Ei(this);
                this.Eier.Add(ei);
                this.Gewicht -= ei.Gewicht;
            }
        }

        public override void Fressen()
        {
            if (this.Gewicht < 2000)
            {
                this.Gewicht += 75;
            }
        }
    }
}
