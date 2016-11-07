using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    class Exam
    {
        public string Subject { get; set; }
        public byte Mark { get; set; }

        public Exam(string subject, byte mark)
        {
            this.Subject = subject;
            this.Mark = mark;
        }
    }
}
