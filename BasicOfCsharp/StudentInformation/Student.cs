using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    class Student
    {
      
        public Student(String firstName, String lastName, String teacher, String sub, float mark)
        {
            FirstName = firstName;
            LastName = lastName;
            Teacher = teacher;
            Subject = sub;
            Mark = mark;
        }

        public Student(int id,String firstName, String lastName, String teacher, String sub, float mark)
        {
            StudentID = id;
            FirstName = firstName;
            LastName = lastName;
            Teacher = teacher;
            Subject = sub;
            Mark = mark;

        }

        public int StudentID { get; set; }
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public String Teacher { get; set; }
        public String Subject { get; set; }
        public String Branch { get; set; }
        public float Mark { get; set; }

    }
}