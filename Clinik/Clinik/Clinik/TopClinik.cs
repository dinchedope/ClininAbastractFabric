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
    internal class TopClinik : AbstractClinik
    {
        public override AbstractSurvey GetSurvey()
        {
            return new PrimeSurvey();
        }
        public override AbstractInjection GetInjection()
        {
            return new PrimeInjection();
        }

        public override AbstractTablet GetTablet()
        {
            return new PrimeTablet();
        }
    }
}
