using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinik.Survey
{
    internal abstract class AbstractSurvey
    {
        public string Name;
        public string Description;

        public abstract string Do();
    }
}
