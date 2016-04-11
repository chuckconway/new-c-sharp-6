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


// Type: CSharp6.NewFeatures.ExceptionFilters.ExceptionFilterExample 
// Assembly: CSharp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BD66D20E-AF5A-48D6-9053-9D362D83A0DA
// Location: C:\Projects\new-c-sharp-6\bin\Debug\CSharp6.dll
// Sequence point data from decompiler

.class private auto ansi beforefieldinit
  CSharp6.NewFeatures.ExceptionFilters.ExceptionFilterExample
    extends[mscorlib] System.Object
{

  .method public hidebysig instance void
    Example() cil managed
{
    .maxstack 2
    .locals init (
      [0] string V_0,
      [1]
    int32 num,
      [2] class CSharp6.NewFeatures.ExceptionFilters.MyException ex,
      [3] bool V_3,
      [4] class [mscorlib]
System.DivideByZeroException ex
    )

    IL_0000: nop
    .try
    {
      IL_0001: nop

      // [23 9 - 23 43]
      IL_0002: ldstr        "0"
      IL_0007: stloc.0      // V_0

      IL_0008: ldc.i4.3     
      IL_0009: ldloc.0      // V_0
      IL_000a: call int32[mscorlib]System.Convert::ToInt32(string)
      IL_000f: div
      IL_0010: stloc.1      // num
      IL_0011: nop
      IL_0012: leave.s IL_003c
    } // end of .try
    filter
    {
      IL_0014: isinst CSharp6.NewFeatures.ExceptionFilters.MyException
      IL_0019: dup
      IL_001a: brtrue.s IL_0020
      IL_001c: pop
      IL_001d: ldc.i4.0     
      IL_001e: br.s IL_002f

    // [25 7 - 25 62]
      IL_0020: stloc.2      // ex

    // [25 30 - 25 62]
      IL_0021: ldloc.2      // ex
      IL_0022: callvirt instance class [mscorlib]
System.Exception[mscorlib] System.Exception::get_InnerException()
      IL_0027: ldnull
      IL_0028: cgt.un
      IL_002a: stloc.3      // V_3

      IL_002b: ldloc.3      // V_3
      IL_002c: ldc.i4.0     
      IL_002d: cgt.un
      IL_002f: endfilter    
    } // end of filter
    { // start of filter handler
      IL_0031: pop
      IL_0032: nop
      IL_0033: nop
      IL_0034: leave.s IL_003c
    } // end of filter handler
    catch [mscorlib]
System.DivideByZeroException
    {

    // [28 7 - 28 39]
      IL_0036: stloc.s ex
      IL_0038: nop
      IL_0039: nop

      IL_003a: leave.s IL_003c
    } // end of catch
    IL_003c: ret          

  } // end of method ExceptionFilterExample::Example

  .method public hidebysig specialname rtspecialname instance void 
    .ctor() cil managed
{
    .maxstack 8

    // [16 7 - 16 24]
    IL_0000: ldarg.0      // this
    IL_0001: call instance void [mscorlib]
    System.Object::.ctor()
    IL_0006: nop
    IL_0007: ret

} // end of method ExceptionFilterExample::.ctor
} // end of class CSharp6.NewFeatures.ExceptionFilters.ExceptionFilterExample
