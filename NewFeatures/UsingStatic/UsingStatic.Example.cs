

namespace CSharp6.NewFeatures.UsingStatic
{
    using static System.Console;
    using static System.Math;
    using static System.DayOfWeek;

    public class UsingStaticExample
    {
        static void Main()
        {
            WriteLine(Sqrt(3 * 3 + 4 * 4));
            WriteLine(Friday - Monday);
        }
    }
}

namespace CSharp6.NewFeatures.UsingNotStatic
{
    using System;

    public class UsingStatic
    {
        static void Main()
        {
            Console.WriteLine(Math.Sqrt(3 * 3 + 4 * 4));
            Console.WriteLine(DayOfWeek.Friday - DayOfWeek.Monday);
        }
    }
}

namespace CSharp6.NewFeatures.Custom
{
    using static CSharp6.NewFeatures.MyExtensions.Ext;

    public class UsingStatic
    {
        public string NoneifyMyString()
        {
            return Noneify();
        }
    }
}

namespace CSharp6.NewFeatures.MyExtensions
{
    public static class Ext
    {
        public static string Noneify()
        {
            return string.Empty;
        } 
    }
}
