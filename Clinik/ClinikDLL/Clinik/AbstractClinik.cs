using Injection;
using Survey;
using Tablet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinik
{
    public abstract class AbstractClinik
    {
        public string name;

        public abstract AbstractSurvey GetSurvey();
        public abstract AbstractTablet GetTablet();
        public abstract AbstractInjection GetInjection();
    }
}
