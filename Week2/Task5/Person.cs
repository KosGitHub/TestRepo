using System;
using System.Collections.Generic;

namespace Task5
{
    abstract class Person: ICloneable
    {
        public string Fio { get; set; }
        public byte Age { get; set; }

        public Person() { }
        // Person constructor
        public Person(string fio, byte age)
        {
            this.Fio = fio;
            this.Age = age;
        }

        // Write information abou person to Console
        public virtual void Print()
        {
            Console.Write("FIO: {0}, age: {1}", this.Fio, this.Age);
        }

        // My override of ToString() method for Person
        public override string ToString()
        {
            return string.Format(this.Fio);
        }

        // My override of GetHashCode() method for Person
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        // My override of Equals() method for Person
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Person person = (Person)obj;
            return (this.Fio == person.Fio && this.Age == person.Age);
        }

        // My virtual Clone() method
        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    static class PersonExtenshion
    {
        // Extenshion generic method RandomPerson for getting 1 random person from List<Person>
        public static T RandomPerson<T>(this List<T> persons)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, persons.Count);
            return persons[index];
        }

        // Extenshion generic method GetObjectsOfType for calculating how much does some object type includes in List of objects
        public static uint GetObjectsOfType<TypeList, TypeSearching>(this List<TypeList> persons, TypeSearching typeSearching)
        {
            uint counter = 0;
            if (persons != null)
            {
                if (typeSearching is Person)
                {
                    foreach (var person in persons)
                    {
                        if (person.GetType() == typeSearching.GetType())
                        {
                            counter++;
                        }
                    }    
                }
                else
                {
                    Console.WriteLine("There are no {0} objects in {1}", typeSearching.GetType(), persons);    
                }
            }
            else
            {
                Console.WriteLine("List of Persons is empty!");
            }
            return counter;
        }
    }
}