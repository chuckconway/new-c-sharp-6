// Decompiled with JetBrains decompiler
// Type: CSharp6.NewFeatures.StringInterpolation.StringInterpolationExample
// Assembly: CSharp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2B497135-5C59-44D1-9D10-10B8D918D9DE
// Assembly location: C:\Projects\new-c-sharp-6\bin\Debug\CSharp6.dll
// Compiler-generated code is shown

namespace CSharp6.NewFeatures.StringInterpolation
{
    internal class StringInterpolationExample
    {
        public StringInterpolationExample()
        {
            base.\u002Ector();
        }

        public string OldWay()
        {
            return string.Format("({0}) {1} - {2}", (object)"432", (object)"321", (object)"2343");
        }

        public string NewWay()
        {
            return string.Format("({0}) {1} - {2}", (object)"432", (object)"321", (object)"2343");
        }
    }
}
