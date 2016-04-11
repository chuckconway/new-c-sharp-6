using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.NewFeatures.NullConditionalOperator
{
    class NullConditionalOperatorExample
    {
        public IEnumerable<string> OldWay()
        {
            var source = new List<string>();

            if (source != null)
            {
                return source.Select(Convert);
            }

            return null;
        }

        public IEnumerable<string> NewWay()
        {
            var source = new List<string>();
            return source?.Select(Convert);
        }

        public string Convert(string s)
        {
            return string.Empty;
        }
    }
}
