using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {
        private float _gpa;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set;  }


        public float GPA
        {
            get { return _gpa; }
            set
            {
                _gpa = value >= 0 && value <= 4 ? value : 0;
            }
        }


        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            GPA = gpa;

        }//end ctor

        public override string ToString()
        {
            return string.Format("First Name: {0}\nLast Name: {1}\nID: {2}\nGPA: {3:n1}\n", FirstName, LastName, Id, GPA);
        }
    }
}
