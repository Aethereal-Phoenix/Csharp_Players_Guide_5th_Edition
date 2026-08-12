using System;
using System.Collections.Generic;
using System.Text;

namespace Lvl18_C1_Vin_Fletcher_s_Arrows
{
    internal class Arrow
    {
        private Arrowhead _arrowhead;
        private double _shaft;
        private Fletching _fletching;

        public Arrowhead _Arrowhead { get { return _arrowhead; } set { _arrowhead = value; } }
        public double _Shaft { get { return _shaft; } set { _shaft = value; } }
        public Fletching _Fletching { get { return _fletching; } set { _fletching = value; } }


    }
}
