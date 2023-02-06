using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablet
{
    public class StandartTablet : AbstractTablet
    {
        public string Desctiption;

        public override string Do()
        {
            return "Standart Tablet";
        }
    }
}
