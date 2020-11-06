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
            //*****STUDENT*****
            Console.WriteLine("****STUDENT****");

            Student s1 = new Student("Spongebob", "Squarepants", "256", 2.8f);
            Student s2 = new Student("Michael", "Scott", "659", 0.19f);

            Console.WriteLine(s1);
            Console.WriteLine(s2);


            //*****VEHICLE*****
            Console.WriteLine("****VEHICLE****");

            Vehicle v1 = new Vehicle("Kia", "Optima", 2015, 3005f);
            Vehicle v2 = new Vehicle("Acura", "TL", 2008, 2750f);

            Console.WriteLine(v1);
            Console.WriteLine(v2);


            //*****LOGIN*****
            Console.WriteLine("****LOGIN****");

            Login l1 = new Login("MScott1", "WorldsBestBoss");
            Login l2 = new Login("DSchrute", "SchruteFarms");

            Console.WriteLine(l1);
            Console.WriteLine(l2);


            //*****CONTACT INFO*****
            Console.WriteLine("****CONTACTINFO****");

            ContactInfo c1 = new ContactInfo("123 Main St.", "Springfield", "Mars", "12345", "1234567890", "email@email.email");
            ContactInfo c2 = new ContactInfo("987 Secondary Dr.", "Boardfield", "Jupitar", "98765", "9876543210", "example@example.email");

            Console.WriteLine(c1);
            Console.WriteLine(c2);


            //*****CUSTOMER*****



            //*****CREDIT CARD ACCOUNT*****



            //*****BOOK*****



            //*****LIBRARY*****



            //*****SONG*****



            //*****ARTIST*****



            //*****MOTOR HOME - extend VEHICLE*****



            //*****TRUCK - extend VEHICLE*****

        }
    }
}
