using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reederei
{
    public class Fracht : FrachtBasis, ILadbar
    {
        public string Bezeichnung
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Einheit
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int Menge
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}