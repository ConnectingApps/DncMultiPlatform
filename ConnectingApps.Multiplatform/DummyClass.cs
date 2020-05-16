using System;
using System.Threading.Tasks;

namespace ConnectingApps.Multiplatform
{
    public class DummyClass 
        #if NETCOREAPP3_1 
        : IAsyncDisposable 
        #endif
    {
        public void DoSomething()
        {
            Console.WriteLine("Something needs is done");
        }

        public void Dispose()
        {
            Console.WriteLine("Object is disposed");
        }

        #if NETCOREAPP3_1
        public async ValueTask DisposeAsync()
        {
            Console.WriteLine("Object is disposed asynchronously");
        }
        #endif
    }
}