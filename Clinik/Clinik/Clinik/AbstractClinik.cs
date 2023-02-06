using Clinik.Injection;
using Clinik.Survey;
using Clinik.Tablet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinik.Clinik
{
    internal abstract class AbstractClinik
    {
        public string name;

        public abstract AbstractSurvey GetSurvey();
        public abstract AbstractTablet GetTablet();
        public abstract AbstractInjection GetInjection();
    }
}
