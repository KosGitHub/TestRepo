namespace Task5
{
    struct Subject
    {
        public int subjectId;
        public string name;
        public Subject(int id, string name)
        {
            this.subjectId = id;
            this.name = name;
        }

        public override string ToString()
        {
            return string.Format(this.name);
        }
    }
}
