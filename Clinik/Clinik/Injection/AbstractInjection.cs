using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinik.Injection
{
    internal abstract class AbstractInjection
    {
        public string name;
        public abstract string Do();
    }
}
