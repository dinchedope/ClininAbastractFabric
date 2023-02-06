using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinik.Survey
{
    internal class BadSurvey : AbstractSurvey
    {
        public string Description;

        public override string Do()
        {
            return "Bad Survey";
        }
    }
}
