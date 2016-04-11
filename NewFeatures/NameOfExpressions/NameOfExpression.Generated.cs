// Decompiled with JetBrains decompiler
// Type: CSharp6.NewFeatures.NameOfExpressions.NameOfExpressionExample
// Assembly: CSharp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 46C6DFB3-EC89-499D-B72E-FE4EA8EB0A93
// Assembly location: C:\Projects\new-c-sharp-6\bin\Debug\CSharp6.dll
// Compiler-generated code is shown

using System;

namespace CSharp6.NewFeatures.NameOfExpressions
{
    internal class NameOfExpressionExample
    {
        public NameOfExpressionExample()
        {
            base.\u002Ector();
        }

        public void Example(int myVariableName, string myStringVarableName)
        {
            Console.WriteLine(string.Format("{0}, {1}", (object)"myStringVarableName", (object)"myStringVarableName"));
        }
    }
}
