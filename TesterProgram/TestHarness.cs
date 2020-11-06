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


            Console.WriteLine("****VEHICLE****");

            Vehicle v1 = new Vehicle("Kia", "Optima", 2015, 3005f);
            Vehicle v2 = new Vehicle("Acura", "TL", 2008, 2750f);

            Console.WriteLine(v1);
            Console.WriteLine(v2);


            Console.WriteLine("****LOGIN****");

            Login l1 = new Login("MScott1", "WorldsBestBoss");
            Login l2 = new Login("DSchrute", "SchruteFarms");

            Console.WriteLine(l1);
            Console.WriteLine(l2);
        }
    }
}
