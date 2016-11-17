namespace Task11._1
{
    class Teacher: Person
    {
        public string Subject { get; set; }

        public Teacher(string name, byte age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" subject {0}", Subject);
        }
    }
}
