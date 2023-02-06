using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey
{
    public abstract class AbstractSurvey
    {
        public string Name;
        public string Description;

        public abstract string Do();
    }
}
