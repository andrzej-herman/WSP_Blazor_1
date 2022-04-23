using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client
{
    public class Student
    {

        public Student()
        {
            
        }
        public Student(int id, string fn, string ln)
        {
            StudentId = id;
            Name = fn;
            Surname = ln;
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}