using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class TestHarness
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****STUDENT****");

            Student s1 = new Student("Spongebob", "Squarepants", "256", 2.8f);
            Student s2 = new Student("Michael", "Scott", "659", 0.19f);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
