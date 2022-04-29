using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    class StudentDetails
    {
        Student st = new Student("V", "Ramya", "Smith", "Maths", 89);
        Student st1 = new Student("V", "Deepti", "Jhon", "English", 100);

        public void display()
        {

            Console.WriteLine("{0}, {1} {2} {3} {4} ", st.FirstName, st.LastName, st.Teacher, st.Subject, st.Mark);
            Console.WriteLine("{0}, {1} {2} {3} {4}" ,st1.FirstName, st1.LastName, st1.Teacher, st1.Subject, st1.Mark);

        }

    }
}
