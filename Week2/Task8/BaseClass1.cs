using System;

namespace Task8
{
    // The base class without unmanaged resources
    class BaseClass1: IDisposable
    {
        private bool _disposed = false;
        public ManagedResource BaseManagedProperty { get; set; } // Managed resource in base class

        // For example we decided to realize Dispose() in base class
        public virtual void Dispose() 
        {
            if (!_disposed)
            {
                BaseManagedProperty = null; // Set free our managed resources
                Console.WriteLine("Dispose managed resources of BaseClass1");
                _disposed = true;
            }
        }
    }
}