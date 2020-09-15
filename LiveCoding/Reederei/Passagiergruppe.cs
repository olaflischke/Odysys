using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reederei
{
    public class Passagiergruppe : FrachtBasis, ILadbar
    {
        public List<Person> Personen
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Buchungsnummer
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