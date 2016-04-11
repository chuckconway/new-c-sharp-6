using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.NewFeatures.StringInterpolation
{
    class StringInterpolationExample
    {
        public string OldWay()
        {
            string areaCode = "432";
            string prefix = "321";
            string lineNumber = "2343";

            return string.Format("({0}) {1} - {2}", areaCode, prefix, lineNumber);
        }

        public string NewWay()
        {
            var areaCode = "432";
            var prefix = "321";
            var lineNumber = "2343";

            return string.Format("({0}) {1} - {2}", areaCode, prefix, lineNumber);
        }
    }
}
