using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9A
{
    public class Student
    {
        // Add member fields here
        private string LastName;
        private string FirstName;
        private int _id;

        // Add default and overloaded constructors here
        public Student()
        {
            LastName = "";
            FirstName = "";
            _id = 1000000;
        }

        public Student(string last, string first, int id)
        {
            LastName = last;
            FirstName = first;
            _id = id;
        }

        // add Getters and Setters here

        public string GetLastName() { return LastName; }
        public string GetFirstName() { return FirstName; }
        public int GetId() { return _id; }

        public void SetLastName(string last) { LastName = last; }
        public void SetFirstName(string first) { FirstName = first; }
        public void SetIdNo(int id) { _id = id; }


/******************************************************************************************************
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                      do not modify any of the following code                                        *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
******************************************************************************************************/
        public override string ToString()
        {
            return "ID #: " + GetIDNumber() + "\tName: " + GetLastName() + ", " + GetFirstName();
        }

        public override bool Equals(object obj)
        {
            bool same = true;
            Student s2 = (Student)obj;
            if (this.GetLastName() != s2.GetLastName() || this.GetFirstName() != s2.GetFirstName() || this.GetIDNumber() != s2.GetIDNumber())
            {
                same = false;
            }
            return same;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
