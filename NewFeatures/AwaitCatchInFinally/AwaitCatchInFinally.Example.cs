using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.NewFeatures.AwaitCatchInFinally
{
    class AwaitCatchInFinallyExample
    {
        public async void Example()
        {
            Resource res = null;
            try
            {
                res = await Resource.OpenAsync();

            }
            catch (ResourceException e)
            {
                await Resource.LogAsync(res, e);
            }
            finally
            {
                if (res != null) await res.CloseAsync();
            }
        }
    }

    internal class ResourceException : Exception
    {
    }

    internal class Resource
    {
        public static Task<Resource> OpenAsync()
        {
            throw new NotImplementedException();
        }

        public static Task LogAsync(Resource res, ResourceException resourceException)
        {
            throw new NotImplementedException();
        }

        public Task CloseAsync()
        {
            throw new NotImplementedException();
        }
    }
}
