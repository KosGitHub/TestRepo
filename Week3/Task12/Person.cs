using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    abstract class Person: IPrintable, ICloneable, IDisposable
    {
        public string Name { get; set; }
        public byte Age { get; set; }

        public Person(string name, byte age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Print()
        {
            Console.Write("Name: {0}, age: {1}", Name, Age);
        }

        void IPrintable.Print()
        {
            Console.Write("IPrintable.Print in Person class - Name: {0}, age: {1}", Name, Age);    
        }

        public virtual object Clone()
        {
            return MemberwiseClone();
        }

        public void Dispose()
        {
            Console.WriteLine("Method Dispose() from class Person running...");
        }
    }
}