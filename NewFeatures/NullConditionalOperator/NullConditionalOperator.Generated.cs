// Decompiled with JetBrains decompiler
// Type: CSharp6.NewFeatures.NullConditionalOperator.NullConditionalOperatorExample
// Assembly: CSharp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AF074652-73A3-41A0-84A6-1A1DBB5EE8B0
// Assembly location: C:\Projects\new-c-sharp-6\bin\Debug\CSharp6.dll
// Compiler-generated code is shown

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp6.NewFeatures.NullConditionalOperator
{
    internal class NullConditionalOperatorExample
    {
        public NullConditionalOperatorExample()
        {
            base.\u002Ector();
        }

        public IEnumerable<string> OldWay()
        {
            List<string> list = new List<string>();
            if (list != null)
            {
                // ISSUE: method pointer
                return Enumerable.Select<string, string>((IEnumerable<string>)list, new Func<string, string>((object)this, __methodptr(Convert)));
            }
            return (IEnumerable<string>)null;
        }

        public IEnumerable<string> NewWay()
        {
            List<string> list = new List<string>();
            // ISSUE: method pointer
            return list != null ? Enumerable.Select<string, string>((IEnumerable<string>)list, new Func<string, string>((object)this, __methodptr(Convert))) : (IEnumerable<string>)null;
        }

        public string Convert(string s)
        {
            return string.Empty;
        }
    }
}