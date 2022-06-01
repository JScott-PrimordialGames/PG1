using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9A
{
    public class Submission
    {
        public static Student[] enrollment = new Student[0];

        public static Student Test1(string last, string first, int idNo)
        {
            Student student = new Student(last, first, idNo);
            return student;
        }

        public static Student Test2()
        {
            Student student = new Student();
            return student;
        }

        public static bool Test3(Student enrolled)
        {
            for (int i = 0; i < enrollment.Length; i++)
            {
                if (enrollment[i] == null)
                {
                    enrollment[i] = enrolled;
                    return true;
                }
            }
            return false;
        }

        public static bool Test4(int idNumber)
        {
            for (int i = 0; i < enrollment.Length; i++)
            {
                if (enrollment[i].GetId() == idNumber)
                {
                    enrollment[i] = null;
                    return true;
                }

            }
                return false;
        }

        public static Student Test5(int idNumber)
        {
            for (int i = 0; i < enrollment.Length; i++)
            {
                if (enrollment[i].GetId() == idNumber)
                {
                    return enrollment[i];
                }
            }
            return null;
        }
    }
}
