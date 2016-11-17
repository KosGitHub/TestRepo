using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Persons : IEnumerable
    {
        private List<Person> list;

        public Persons()
        {
            list = new List<Person>();
        }

        public int Count
        {
            get { return list.Count; }
        }

        public Person this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        public void Add(Person p)
        {
            list.Add(p);
        }

        public void AddRange(Person[] p)
        {
            list.AddRange(p);
        }

        public int IndexOf(Person p)
        {
            return list.IndexOf(p);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }
    }
}
