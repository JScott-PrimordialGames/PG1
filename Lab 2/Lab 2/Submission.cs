using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSPG1
{
    class Submission
    {
        /*
         * 
         * For this lab you are required to use the Parse() method 
         * for each conversion. No credit will be given for calls
         * using the Convert class (i.e. Convert.ToInt32)
         * 
        */

        // Given a string, using the Int32 class, convert the string 
        // to an integer. Return the integer
        public static int Test3(string input)
        {
            if(Int32.TryParse(input, out int result))
                return result;

            return 0;
        }

        // Given a string, using the SByte class, convert the string 
        // to a signed byte. Return the signed byte
        public static sbyte Test4(string input)
        {
            if(sbyte.TryParse(input, out sbyte result))
                return (sbyte)result;

            return 0;
        }

        // Given a string, using the Double class, convert the string 
        // to a double Return the double
        public static double Test5(string input)
        {
            if(double.TryParse(input, out double result))
                return (double)result;

            return 0;
        }

        // Given a string, using the UInt16 class, convert the string
        // to a unsigned short. Return the unsigned short
        public static ushort Test6(string input)
        {
            if(ushort.TryParse(input, out ushort result))
                return (ushort)result;

            return 0;
        }

        // Given a string, using the Single class, convert the string 
        // to a float. Return the float
        public static float Test7(string input)
        {
            if(Single.TryParse(input, out Single result))
                return (float)result;

            return 0;
        }

        // Given a string, using the UInt32 class, convert the string 
        // to an unsigned integer. Return the unsigned integer
        public static uint Test8(string input)
        {
            if(UInt32.TryParse(input,out uint result))
                return (uint)result;

            return 0;
        }

        // Given a string, using the Int16 class, convert the string 
        // to a short. Return the short
        public static short Test9(string input)
        {
            if(Int16.TryParse(input,out Int16 result))
                return (short)result;

            return 0;
        }

        // Given a string, using the UInt64 class, convert the string 
        // to an unsigned long. Return the unsigned long
        public static ulong Test10(string input)
        {
            if(UInt64.TryParse(input,out UInt64 result))
                return (ulong)result;

            return 0;
        }
    }
}
