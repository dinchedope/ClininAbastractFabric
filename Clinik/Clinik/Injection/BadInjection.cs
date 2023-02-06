using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinik.Injection
{
    internal class BadInjection : AbstractInjection
    {
        public string Description;

        public BadInjection()
        {

        }

        public override string Do()
        {
            return "Very bad Injection";
        }
    }
}
