
using System;

namespace Task8
{
    // The inherited class with unmanaged resources
    class InheritedClass2: BaseClass2
    {
        private bool _disposed = false;

        public ManagedResource InheritManagedResource { get; set; } // Managed resource in inherited class
        public UnmanagedResource InheritUnmanagedResource { get; set; } // Unmanaged resource in inherited class

        public override void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Don't use Finalize() for current object
        }

        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    InheritManagedResource = null; // Set free our managed resources
                    Console.WriteLine("Dispose managed resources of InheriterClass2");
                }
                InheritUnmanagedResource = null; // Set free our unmanaged resources
                Console.WriteLine("Dispose unmanaged resources of InheriterClass2");
                _disposed = true;
            }
            base.Dispose(disposing); // Call Dispose(bool) from base class
        }

        // Destructor of inherited class
        ~InheritedClass2()
        {
            Dispose(false);
        }
    }
}
