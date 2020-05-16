using System;

namespace ConnectingApps.Shared
{
    public partial class DummyClass : IDisposable
    {
        public void DoSomething()
        {
            Console.WriteLine("Something needs is done");
        }

        public void Dispose()
        {
            Console.WriteLine("Something is disposed");
        }
    }
}
