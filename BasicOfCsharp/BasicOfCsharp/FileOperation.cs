using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace BasicOfCsharp
{
    class FileOperation
    {
        public void WriteLine()
        {
            string content = "Name, ID, Dept";
            File.WriteAllText("C://FSD_.net", content);
     
        }

        public void updateFile()
        {
            String employee = "\nRamya, 1, Finance";
            File.AppendAllText("D://Employee.txt", employee);

        }

        public void ReadFile()
        {
            String content = File.ReadAllText("D://Employee.txt");
            Console.WriteLine(content);
            String[] contents = File.ReadAllLines("D://Employee.txt");
        }
    }
}
