using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speelkaarten
{
    public enum Suite {Harten,Schoppen,Klaveren,Ruiten}
    class Speelkaart
    {
        public int Waarde { get; set; }
        public Suite Teken { get; set; }
        public Speelkaart(int waarde,Suite teken)
        {
            Waarde = waarde;
            Teken = teken;
        }
    }
}
