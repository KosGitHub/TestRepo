using System;

namespace Task11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex();
            complex1.Value = 14.2;

            double someDouble = 2.8;
            
            // Convertion double -> Complex and Complex -> double
            Complex complex2 = someDouble;
            Console.WriteLine("Complex structure after implicit conversion from double variable is {0}",complex2);
            someDouble = (double) complex1;
            Console.WriteLine("Double variable after explicit convertion from Complex struct is {0}", someDouble);

            Console.WriteLine(new string('-', 50));
            // Comparing of two Complex structures
            if (complex1.Equals(complex2))
            {
                Console.WriteLine("Complex structures {0} and {1} are equals", complex1, complex2);
            }
            else
            {
                Console.WriteLine("Complex structures {0} and {1} are not equals", complex1, complex2);
            }

            Complex complex3 = new Complex();
            complex3.Value = 14.2;
            if (complex1.Equals(complex3))
            {
                Console.WriteLine("Complex structures {0} and {1} are equals", complex1, complex3);
            }
            else
            {
                Console.WriteLine("Complex structures {0} and {1} are not equals", complex1, complex3);
            }

            Console.WriteLine(new string('-', 50));
            // Making arithmetical operations
            Console.WriteLine("Adding of Complex structures: {0} + {1} = {2}", complex1, complex2, complex1 + complex2);
            Console.WriteLine("Substraction of Complex structures: {0} - {1} = {2}", complex1, complex2, complex1 - complex2);
            Console.WriteLine("Multiplication of Complex structures: {0} * {1} = {2}", complex1, complex2, complex1 * complex2);
            Console.WriteLine("Division of Complex structures: {0} / {1} = {2}", complex1, complex2, complex1 / complex2);

            Console.ReadLine();
        }
    }
}
