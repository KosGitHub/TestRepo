namespace Task11._1
{
    abstract class Person
    {
        public string Name { get; set; }
        public byte Age { get; set; }

        public Person(string name, byte age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} years", Name, Age);
        }

        public static bool operator ==(Person person1, Person person2)
        {
            if (person1.ToString() == person2.ToString())
            {
                return true;
            }
                return false;
        }

        public static bool operator !=(Person person1, Person person2)
        {
            if (person1.ToString() != person2.ToString())
            {
                return true;
            }
            return false;
        }
    }
}
