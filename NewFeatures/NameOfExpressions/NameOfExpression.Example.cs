using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.NewFeatures.NameOfExpressions
{
    class NameOfExpressionExample
    {
        public void Example(int myVariableName, string myStringVarableName)
        {
            var firstName = nameof(myStringVarableName);
            var secondVarableName = nameof(myStringVarableName);

            Console.WriteLine($"{firstName}, {secondVarableName}");
        }
    }
}
