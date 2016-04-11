using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.NewFeatures.IndexInitializers
{
    class IndexInitializerExample
    {
        public void Example()
        {
            var numbers = new Dictionary<int, string>
            {
                [7] = "sete",
                [9] = "nove",
                [13] = "treze"
            };
        }
    }
}
