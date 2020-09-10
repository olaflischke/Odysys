using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public class Huhn
    {

        public Huhn(string name)
        {
            this.Name = name;
            this.Gewicht = 1000;

        }

        public void Fressen()
        {
            if (this.Gewicht < 3000)
            {
                //this.Gewicht = this.Gewicht + 100;
                this.Gewicht += 100;
            }
        }

        public void EiLegen()
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

        public string Name { get; set; } //= "Neues Huhn";
        public double Gewicht { get; set; }

        public List<Ei> Eier { get; set; } = new List<Ei>(); //Auto-Property-Initializer
    }
}
