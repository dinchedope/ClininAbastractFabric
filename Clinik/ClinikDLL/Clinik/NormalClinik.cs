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
    public class NormalClinik : AbstractClinik
    {
        public override AbstractSurvey GetSurvey()
        {
            return new StandartSurvey();
        }
        public override AbstractInjection GetInjection()
        {
            return new StandartInjection();
        }

        public override AbstractTablet GetTablet()
        {
            return new StandartTablet();
        }
    }
}
