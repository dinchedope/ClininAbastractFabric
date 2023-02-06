using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection
{
    public class StandartInjection : AbstractInjection
    {
        public string Description;

        public override string Do()
        {
            return "Normal Injection";
        }
    }
}
