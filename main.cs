using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

public class Class1
{
	public Class1()
	{

        //simple plus
        static double Plus(double a, double b)
        {
            if (a == 0 && b != 0)
                return b;
            else if (b == 0 && a != 0)
                return a;
            else if (a == 0 && b == 0)
                return 0;
            else if (a == b)
            {
                if (!Overfloat(in a, in a))
                    return a * 2;
                else
                {
                    Debug.WriteLine("Overfloat ");
                    return Double.MaxValue;
                }
            }
            else
            {
                if (!Overfloat(in a, in b))
                    return a + b;
                else
                    return Double.MaxValue;
            }

            bool Overfloat(in double value1, in double value2) //check for overfloating
            {
                return value1 + value2 > Double.MaxValue;
            }
        }

        //simple minus
        static double Minus(double a, double b) 
        {
            if (a == 0 && b != 0)
                return -b;
            else if (b == 0 && a != 0)
                return a;
            else if (a == 0 && b == 0)
                return 0;
            else if (a == b)
                return 0;
            else
            {
                if (!Underfloat(in a, in b))
                    return a - b;
                else
                {
                    Debug.WriteLine("Underfloat");
                    return double.MinValue;
                }
            }

            bool Underfloat(in double value1, in double value2) //check for underfloating
            {
                return value1 - value2 < Double.MinValue;
            }
        }

        static double Gange(double a, double b)
        {
        return a * b;
        }

        static double Divider(double a, double b)
        {
        return a / b;
        }

	}
}


class Program
{
    static void Main(string[] args)
    {

    }
}
