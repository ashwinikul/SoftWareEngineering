using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main()
        {
            string path = @"D:\HW3_Csharp.html";

            // Create the file.
            using (FileStream fs = File.Create(path, 1024))
            {
                string[] Course_Name = new string[3] { "Software Engineering", "Database System", "Internet Of Things" };
                string sem = "Fall 2016";
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    w.WriteLine("<!DOCTYPE html><html><head><title>Course Details</title></head><body><table  border=\"1\"><tr><th><B>Semester</B></th><th><B>Course</B></th></tr>");
                    
                    for (int i=0; i<3; i++)
                    {
                        w.WriteLine("<tr><td>"+sem+"</td><td>"+ Course_Name[i] + "</td></tr>");

                    }
                    w.WriteLine("</table></body></html>");
                }
               
            }

        }
    }
}
