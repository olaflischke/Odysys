using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reederei
{
    public interface ILadbar
    {
        Hafen Starthafen { get; set; }
        Hafen Zielhafen { get; set; }
    }
}