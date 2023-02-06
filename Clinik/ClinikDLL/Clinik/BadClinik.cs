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
    public class BadClinik : AbstractClinik
    {
        public override AbstractSurvey GetSurvey()
        {
            return new BadSurvey();
        }
        public override AbstractInjection GetInjection()
        {
            return new BadInjection();
        }

        public override AbstractTablet GetTablet()
        {
            return new BadTablet();
        }
    }
}
