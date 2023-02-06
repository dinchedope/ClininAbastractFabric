using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinik.Injection
{
    internal class PrimeInjection : AbstractInjection
    {
        public string Description;

        public override string Do()
        {
            return "Prime Injection";
        }
    }
}
