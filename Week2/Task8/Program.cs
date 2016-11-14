using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task8.1 check
            BaseClass1 baseClass1 = new BaseClass1();
            Console.WriteLine("Create new BaseClass1");
            baseClass1.BaseManagedProperty = new ManagedResource();

            InheritedClass1 inheritedClass1 = new InheritedClass1();
            Console.WriteLine("Create new InheritedClass1");
            inheritedClass1.InheritManagedResource = new ManagedResource();
            inheritedClass1.InheritUnmanagedResource = new UnmanagedResource();

            baseClass1.Dispose();
            baseClass1.Dispose();
            baseClass1.Dispose();
            inheritedClass1.Dispose();

            Console.WriteLine(new string('-', 20));

            //Task8.2 check
            BaseClass2 baseClass2 = new BaseClass2();
            Console.WriteLine("Create new BaseClass2");
            baseClass2.BaseManagedResource = new ManagedResource();
            baseClass2.BaseUnmanagedResource = new UnmanagedResource();

            InheritedClass2 inheritedClass2 = new InheritedClass2();
            Console.WriteLine("Create new InheritedClass2");
            inheritedClass2.InheritManagedResource = new ManagedResource();
            inheritedClass2.InheritUnmanagedResource = new UnmanagedResource();

            baseClass2.Dispose();
            inheritedClass2.Dispose();

            Console.ReadLine();
        }
    }
}
