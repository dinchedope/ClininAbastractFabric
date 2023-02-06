using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey
{
    public class StandartSurvey : AbstractSurvey
    {
        public string Description;

        public override string Do()
        {
            return "Standart Survey";
        }
    }
}
