using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public class Ei
    {
        // Konstruktor - wird ausgeführt wenn: Ei ei = new Ei();
        public Ei()
        {
            Random random = new Random();
            // Ei-Gewicht zufällig erzeugen
            this.Gewicht = random.Next(45, 80);
            //_gewicht = 55; geht, aber besser nicht machen

            this.Farbe = (EiFarbe)random.Next(Enum.GetNames(typeof(EiFarbe)).Length);   // DirectCast - schmeißt Exception, wenn Cast fehlschlägt!
        }

        // Lokale Variable
        // Öffentliches Feld
        public string name;// = "Olaf";

        // Full qualified Property
        // Backing Field
        private double _gewicht;
        // Public Setter/Getter
        public double Gewicht
        {
            get { return _gewicht; }
            set
            {
                if (value > 0)
                {
                    _gewicht = value;
                }
            }
        }

        private int _id;

        // Ei meinEi=new Ei();
        // meinEi.Id=1;
        // int a = meinEi.Id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        // Auto-Property
        // Property mit automatisch (durch den Compiler) generiertem Backing Field
        public DateTime Legedatum { get; set; }

        public EiFarbe Farbe { get; set; }

    }

    public enum EiFarbe
    {
        Weiß,
        Braun,
        Gruen
    }

}
