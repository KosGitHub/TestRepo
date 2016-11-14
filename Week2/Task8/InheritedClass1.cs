using System;

namespace Task8
{
    // The inherited class with unmanaged resources
    class InheritedClass1: BaseClass1
    {
        private bool _dispoosed = false;
        public ManagedResource InheritManagedResource { get; set; } // Managed resource in inherited class
        public UnmanagedResource InheritUnmanagedResource { get; set; } // Unmanaged resource in inherited class

        public override void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Don't use Finalize() for current object
        }

        protected void Dispose(bool disposing)
        {
            if (!_dispoosed)
            {
                if (disposing)
                {
                    InheritManagedResource = null; // Set free our managed resources
                    Console.WriteLine("Dispose managed resources of InheriterClass1");
                }
                InheritManagedResource = null; // Set free our unmanaged resources
                Console.WriteLine("Dispose unmanaged resources of InheriterClass1");
                _dispoosed = true;
            }
           base.Dispose(); // Call Dispose() from base class
        }

        // Destructor of inherited class
        ~InheritedClass1() 
        {
            Dispose(false);
        }
    }
}
