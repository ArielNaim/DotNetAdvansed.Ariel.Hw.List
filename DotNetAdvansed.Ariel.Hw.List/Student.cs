using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvansed.Ariel.Hw.List
{
    class Student : IComparable<Student>

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int greade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = greade;
        }
        public int CompareTo(Student other)
        {
            if ((this.Grade.CompareTo(other.Grade)) == 0)
            {
            if ((this.LastName.CompareTo(other.LastName)) == 0)
            {
                return (this.FirstName.CompareTo(other.FirstName));
            }
            return (this.LastName.CompareTo(other.LastName));
            }
            return (this.Grade.CompareTo(other.Grade) * -1);
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} ", FirstName, LastName, Grade);
        }
    }
}
