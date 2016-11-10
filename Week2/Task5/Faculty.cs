namespace Task5
{
    struct Faculty
    {
        public int facultyId;
        public string name;
        public Faculty(int id, string name)
        {
            this.facultyId = id;
            this.name = name;
        }
        public override string ToString()
        {
            return string.Format(this.name);
        }
    }
}
