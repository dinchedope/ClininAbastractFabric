using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablet
{
    public class BadTablet : AbstractTablet
    {
        public string Description;

        public override string Do()
        {
            return "Bad Tablet";
        }
    }
}
