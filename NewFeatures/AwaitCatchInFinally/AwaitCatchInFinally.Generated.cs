// Decompiled with JetBrains decompiler
// Type: CSharp6.NewFeatures.AwaitCatchInFinally.AwaitCatchInFinallyGenrated
// Assembly: CSharp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B811086D-6500-4CCD-9A74-C06E2FE8AED4
// Assembly location: C:\Projects\new-c-sharp-6\bin\Debug\CSharp6.dll
// Compiler-generated code is shown

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace CSharp6.NewFeatures.AwaitCatchInFinally
{
    internal class AwaitCatchInFinallyGenrated
    {
        public AwaitCatchInFinallyGenrated()
        {
            base.\u002Ector();
        }

        public void Example()
        {
            AwaitCatchInFinallyGenrated.\u003CExample\u003Ed__0 stateMachine = new AwaitCatchInFinallyGenrated.\u003CExample\u003Ed__0();
            stateMachine.\u003C\u003E4__this = this;
            stateMachine.\u003C\u003Et__builder = AsyncVoidMethodBuilder.Create();
            stateMachine.\u003C\u003E1__state = -1;
            stateMachine.\u003C\u003Et__builder.Start < AwaitCatchInFinallyGenrated.\u003CExample\u003Ed__0 > (ref stateMachine);
        }

        [CompilerGenerated]
        private sealed class \u003CExample\u003Ed__0 : IAsyncStateMachine
    {
      public int \u003C\u003E1__state;
      public AsyncVoidMethodBuilder \u003C\u003Et__builder;
      public AwaitCatchInFinallyGenrated \u003C\u003E4__this;
      private Resource \u003Cres\u003E5__1;
      private object \u003C\u003Es__2;
      private int \u003C\u003Es__3;
      private object \u003C\u003Es__4;
      private int \u003C\u003Es__5;
      private Resource \u003C\u003Es__6;
      private ResourceException \u003Ce\u003E5__7;
      private TaskAwaiter<Resource> \u003C\u003Eu__1;
      private TaskAwaiter \u003C\u003Eu__2;

      public \u003CExample\u003Ed__0()
        {
            base.\u002Ector();
        }

        void IAsyncStateMachine.MoveNext()
        {
            int num1 = this.\u003C\u003E1__state;
            try
            {
                int num2;
                TaskAwaiter awaiter1;
                switch (num1)
                {
                    case 0:
                    case 1:
                        try
                        {
                            TaskAwaiter awaiter2;
                            if (num1 != 0)
                            {
                                if (num1 != 1)
                                {
                                    this.\u003C\u003Es__5 = 0;
                                }
                                else
                                {
                                    awaiter2 = this.\u003C\u003Eu__2;
                                    this.\u003C\u003Eu__2 = new TaskAwaiter();
                                    this.\u003C\u003E1__state = num2 = -1;
                                    goto label_18;
                                }
                            }
                            try
                            {
                                TaskAwaiter<Resource> awaiter3;
                                if (num1 != 0)
                                {
                                    awaiter3 = Resource.OpenAsync().GetAwaiter();
                                    if (!awaiter3.IsCompleted)
                                    {
                                        this.\u003C\u003E1__state = num2 = 0;
                                        this.\u003C\u003Eu__1 = awaiter3;
                                        AwaitCatchInFinallyGenrated.\u003CExample\u003Ed__0 stateMachine = this;
                                        this.\u003C\u003Et__builder.AwaitUnsafeOnCompleted < TaskAwaiter<Resource>, AwaitCatchInFinallyGenrated.\u003CExample\u003Ed__0 > (ref awaiter3, ref stateMachine);
                                        return;
                                    }
                                }
                                else
                                {
                                    awaiter3 = this.\u003C\u003Eu__1;
                                    this.\u003C\u003Eu__1 = new TaskAwaiter<Resource>();
                                    this.\u003C\u003E1__state = num2 = -1;
                                }
                                Resource result = awaiter3.GetResult();
                                awaiter3 = new TaskAwaiter<Resource>();
                                this.\u003C\u003Es__6 = result;
                                this.\u003Cres\u003E5__1 = this.\u003C\u003Es__6;
                                this.\u003C\u003Es__6 = (Resource)null;
                            }
                            catch (ResourceException ex)
                            {
                                this.\u003C\u003Es__4 = (object)ex;
                                this.\u003C\u003Es__5 = 1;
                            }
                            if (this.\u003C\u003Es__5 == 1)
                {
                                this.\u003Ce\u003E5__7 = (ResourceException)this.\u003C\u003Es__4;
                                awaiter2 = Resource.LogAsync(this.\u003Cres\u003E5__1, this.\u003Ce\u003E5__7).GetAwaiter();
                                if (!awaiter2.IsCompleted)
                                {
                                    this.\u003C\u003E1__state = num2 = 1;
                                    this.\u003C\u003Eu__2 = awaiter2;
                                    AwaitCatchInFinallyGenrated.\u003CExample\u003Ed__0 stateMachine = this;
                                    this.\u003C\u003Et__builder.AwaitUnsafeOnCompleted < TaskAwaiter, AwaitCatchInFinallyGenrated.\u003CExample\u003Ed__0 > (ref awaiter2, ref stateMachine);
                                    return;
                                }
                            }
                else
                  goto label_19;
                            label_18:
                            awaiter2.GetResult();
                            TaskAwaiter taskAwaiter = new TaskAwaiter();
                            this.\u003Ce\u003E5__7 = (ResourceException)null;
                            label_19:
                            this.\u003C\u003Es__4 = (object)null;
                        }
                        catch (object ex)
                        {
                            this.\u003C\u003Es__2 = ex;
                        }
                        if (this.\u003Cres\u003E5__1 != null)
              {
                            awaiter1 = this.\u003Cres\u003E5__1.CloseAsync().GetAwaiter();
                            if (!awaiter1.IsCompleted)
                            {
                                this.\u003C\u003E1__state = num2 = 2;
                                this.\u003C\u003Eu__2 = awaiter1;
                                AwaitCatchInFinallyGenrated.\u003CExample\u003Ed__0 stateMachine = this;
                                this.\u003C\u003Et__builder.AwaitUnsafeOnCompleted < TaskAwaiter, AwaitCatchInFinallyGenrated.\u003CExample\u003Ed__0 > (ref awaiter1, ref stateMachine);
                                return;
                            }
                            break;
                        }
                        goto label_26;
                    case 2:
                        awaiter1 = this.\u003C\u003Eu__2;
                        this.\u003C\u003Eu__2 = new TaskAwaiter();
                        this.\u003C\u003E1__state = num2 = -1;
                        break;
                    default:
                        this.\u003Cres\u003E5__1 = (Resource)null;
                        this.\u003C\u003Es__2 = (object)null;
                        this.\u003C\u003Es__3 = 0;
                        goto case 0;
                }
                awaiter1.GetResult();
                awaiter1 = new TaskAwaiter();
                label_26:
                object obj = this.\u003C\u003Es__2;
                if (obj != null)
                {
                    Exception source = obj as Exception;
                    if (source == null)
                        throw obj;
                    ExceptionDispatchInfo.Capture(source).Throw();
                }
                int num3 = this.\u003C\u003Es__3;
                this.\u003C\u003Es__2 = (object)null;
            }
            catch (Exception ex)
            {
                this.\u003C\u003E1__state = -2;
                this.\u003C\u003Et__builder.SetException(ex);
                return;
            }
            this.\u003C\u003E1__state = -2;
            this.\u003C\u003Et__builder.SetResult();
        }

        [DebuggerHidden]
        void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
        {
        }
    }
}
}
