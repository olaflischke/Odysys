﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EierfarmBl
{
    public abstract class Gefluegel  // abstract: Vererbungsmodifier, Klasse kann nicht instanziiert werden
: Vogel
    {
        public Gefluegel(string name)
        {
            this.Name = name;
        }

        // ToString überschrieben
        //public override string ToString()
        //{
        //    return this.Name;
        //}
    }
}