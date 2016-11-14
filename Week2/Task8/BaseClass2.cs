using System;

namespace Task8
{
    // The base class with unmanaged resources
    class BaseClass2: IDisposable
    {
        private bool _disposed = false;

        public ManagedResource BaseManagedResource { get; set; } // Managed resource in base class
        public UnmanagedResource BaseUnmanagedResource { get; set; } // Unmanaged resource in base class

        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Don't use Finalize() for current object
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    BaseManagedResource = null; // Set free our managed resources
                    Console.WriteLine("Dispose managed resources of BaseClass2");
                }
                BaseUnmanagedResource = null; // Set free our unmanaged resources
                Console.WriteLine("Dispose unmanaged resources of BaseClass2");
                _disposed = true;
            }
        }

        // Destructor of base class
        ~BaseClass2()
        {
            Dispose(false);
        }
    }
}
