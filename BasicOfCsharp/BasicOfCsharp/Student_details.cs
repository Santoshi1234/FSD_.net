using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace BasicOfCsharp
{
    class Student_details
    {
        public void WriteLine()
        {
            Console.WriteLine("enter the Students Names");
            string Studcontent = "StuName, ID, Dept";
            File.WriteAllText("C://FSD_.net", Studcontent);


        }
        public void updateFile()
        {
            String Student = "\n Ram, 1, Physics";
            File.AppendAllText("D://Student.txt", Student);

        }

        public void ReadFile()
        {
            String content = File.ReadAllText("D://Employee.txt");
            Console.WriteLine(content);
            String[] contents = File.ReadAllLines("D://Employee.txt");
        }
    }
}
