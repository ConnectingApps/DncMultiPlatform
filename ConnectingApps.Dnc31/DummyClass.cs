using System;
using System.Threading.Tasks;

namespace ConnectingApps.Shared
{
    public partial class DummyClass : IAsyncDisposable
    {
        public async ValueTask DisposeAsync()
        {
            Console.WriteLine("Class is disposed asynchronously");
        }
    }
}
