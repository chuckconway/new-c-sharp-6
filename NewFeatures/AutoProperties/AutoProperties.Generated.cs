using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CSharp6.NewFeatures.AutoProperties
{
    public class AutoPropertiesInitialize
    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string \u003CLastName\u003Ek__BackingField;
    [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string \u003CFirstName\u003Ek__BackingField;

    public string LastName
        {
            get
            {
                return this.\u003CLastName\u003Ek__BackingField;
            }
            set
            {
                this.\u003CLastName\u003Ek__BackingField = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.\u003CFirstName\u003Ek__BackingField;
            }
            set
            {
                this.\u003CFirstName\u003Ek__BackingField = value;
            }
        }

        public AutoPropertiesInitialize()
        {
            this.\u003CLastName\u003Ek__BackingField = "Doe";
            this.\u003CFirstName\u003Ek__BackingField = "John";
            base.\u002Ector();
        }
    }
}