// Decompiled with JetBrains decompiler
// Type: CSharp6.NewFeatures.IndexInitializers.IndexInitializerExample
// Assembly: CSharp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 36C6F166-C5F6-4CEF-B7C4-DDBC42183F8A
// Assembly location: C:\Projects\new-c-sharp-6\bin\Debug\CSharp6.dll
// Compiler-generated code is shown

using System.Collections.Generic;

namespace CSharp6.NewFeatures.IndexInitializers
{
    internal class IndexInitializerExample
    {
        public IndexInitializerExample()
        {
            base.\u002Ector();
        }

        public void Example()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            int index1 = 7;
            string str1 = "sete";
            dictionary[index1] = str1;
            int index2 = 9;
            string str2 = "nove";
            dictionary[index2] = str2;
            int index3 = 13;
            string str3 = "treze";
            dictionary[index3] = str3;
        }
    }
}