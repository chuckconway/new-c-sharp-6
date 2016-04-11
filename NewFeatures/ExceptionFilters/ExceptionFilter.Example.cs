using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.NewFeatures.ExceptionFilters
{
    class ExceptionFilterExample
    {
        public void Example()
        {
            try
            {
                var zero = "0";

                int val = 3/Convert.ToInt32(zero);
            }
            catch (MyException ex) when (ex.InnerException != null)
            {
                // Oh Noos!
            }
            catch (DivideByZeroException ex)
            {
                // ...
            }
        }
    }

    public class MyException : DivideByZeroException
    {
        
    }
}
