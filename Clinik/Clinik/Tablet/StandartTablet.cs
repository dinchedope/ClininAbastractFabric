using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinik.Tablet
{
    internal class StandartTablet : AbstractTablet
    {
        public string Desctiption;

        public override string Do()
        {
            return "Standart Tablet";
        }
    }
}
