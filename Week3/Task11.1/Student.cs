namespace Task11._1
{
    class Student : Person
    {
        public string Faculty { get; set; }
        public byte Course { get; set; }

        public Student(string name, byte age, string faculty, byte course) : base(name, age)
        {
            Faculty = faculty;
            Course = course;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" faculty {0}, cource {1}", Faculty, Course);
        }
    }
}
