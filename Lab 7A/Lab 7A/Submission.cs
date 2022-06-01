using System;
using System.Text;
using Lab_7A;

namespace FSPG1
{
    public class Submission
    {
        public static StringBuilder Test1(string[] names)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string name in names)
            {
                sb.Append(name.Substring(0, 1));
            }
            return sb;
        }

        public static object Test2(float x, float y, float radius)
        {
            circle c1 = new circle(x, y, radius);

            return c1;
        }

        public class circle
        {
            float mX;
            float mY;
            float mRadius;

            public circle(float x, float y, float radius)
            {
                mX = x;
                mY = y;
                mRadius = radius;
            }
            public float GetX() { return mX; }
            public float GetY() { return mY; }
            public float GetRadius() { return mRadius; }

            public float GetArea()
            {
                double pi = Math.PI;
                double result = pi * (mRadius * mRadius);
                return (float)pi;
            }

            public bool Contains(float px, float py)
            {
                if((px - mX) * (px - mX) + (py - mY) * (py - mY) < = mRadius * mRadius)
                    return true;
                else
                    return false;
            }

            public float GetCircumference()
            {
                double pi = Math.PI;
                double result = 2 * pi * mRadius;
                return (float)result;
            }
        }

        public static object Test3(float x, float y, float radius)
        {
            circle c1 = new circle(x, y, radius);

            return c1;
        }

        public static object Test4(float x, float y, float radius)
        {
            circle c1 = new circle(x, y, radius);

            return c1;
        }

        public static object Test5(float x, float y, float radius)
        {
            circle c1 = new circle(x, y, radius);

            return c1;
        }

        public static int Test6(string str1, string str2, bool ignoreCase)
        {
            return String.Compare(str2, str2, ignoreCase);
        }

        public static string Test7(sbyte offset, string message)
        {
            TextCodec codec = new TextCodec(offset);
            return codec.Encode(message);
        }
        
        public class TextCodec
        {
            sbyte mOffset;

            public TextCodec(sbyte offset)
            {
                mOffset = offset;
            }

            public string Encode(string message)
            {
                StringBuilder sb = new StringBuilder(message);
                for (int i = 0; i < message.Length; i++)
                {
                    sb[i] = (char)(sb[i] + mOffset);
                }
                return sb.ToString();
            }

            public string Decode(string message)
            {
                StringBuilder sb = new StringBuilder(message);
                for (int i = 0; i < message.Length; i++)
                {
                    sb[i] = (char)(sb[i] - mOffset);
                }
                return sb.ToString();
            }
        }

        public static string Test8(sbyte offset, string message)
        {
            TextCodec codec = new TextCodec(offset);
            return codec.Decode(message);
        }
    }
}
