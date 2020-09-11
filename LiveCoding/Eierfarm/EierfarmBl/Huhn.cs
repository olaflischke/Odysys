using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public class Huhn : Gefluegel // : Vererbung, gesprochen "ist ein"
    {

        public Huhn(string name) : base(name)
        {
            this.Gewicht = 1000;

        }

        public override void Fressen()
        {
            if (this.Gewicht < 3000)
            {
                //this.Gewicht = this.Gewicht + 100;
                this.Gewicht += 100;
            }
        }

        public override void EiLegen()
        {
            if (this.Gewicht > 1500)
            {
                // Klasse Instanzvariable = new Konstruktor([Parameter]);
                Ei ei = new Ei();
                // Das Ei der Liste hinzufügen
                this.Eier.Add(ei);
                // Das Gewicht des Eis vom Gewicht des Huhns abziehen
                this.Gewicht -= ei.Gewicht;
            }
        }


    }
}
