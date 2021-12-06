using System;

namespace HomeWork2
{
    class Program
    {
        static double Task1(double a, double b)
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a == b)
            {
                return a* b;
            }
            else
            {
                return a - b;
            }
        }

        static double Task2(double x, double y)
        {
            if(x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        static (double a,double b, double c) Task3(double a, double b, double c)
        {
            if (a < b && a < c)
            {
                if (b < c)
                {
                    return (a, b, c);
                }
                else
                {
                    return (a, c, b);
                }
            }
            else if (b < a && b < c)
            {
                if (a < c)
                {
                    return (b, a, c);
                }
                else
                {
                    return (b, c, a);
                }
            }
            else
            {
                if (a < b)
                {
                    return (c, a, b);
                }
                else
                {
                    return (c, b, a);
                }
            }
        }

        static (double x1, double x2) Task4(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            double x1;
            double x2;

            if (discriminant >= 0)
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return ( x1,  x2);
            }
            else
            {
                return (0,0);
            }
        }

        static string Task5(int num)
        {
            string a="";
            string b="";

            if (num < 20)
            {
                switch (num)
                {
                    case 10:
                        a = "Ten";
                        break;
                    case 11:
                        a = "Eleven";
                        break;
                    case 12:
                        a = "Twelve";
                        break;
                    case 13:
                        a = "Thirteen";
                        break;
                    case 14:
                        a = "Fourteen";
                        break;
                    case 15:
                        a = "Fifteen";
                        break;
                    case 16:
                        a = "Sixteen";
                        break;
                    case 17:
                        a = "Seventeen";
                        break;
                    case 18:
                        a = "Eighteen";
                        break;
                    case 19:
                        a = "Nineteen";
                        break;
                }
            }
            else
            {
                switch (num / 10)
                {
                    case 2:
                        a = "Twenty";
                        break;
                    case 3:
                        a = "Thirty";
                        break;
                    case 4:
                        a = "Fourty";
                        break;
                    case 5:
                        a = "Fifty";
                        break;
                    case 6:
                        a = "Sixty";
                        break;
                    case 7:
                        a = "Seventy";
                        break;
                    case 8:
                        a = "Eighty";
                        break;
                    case 9:
                        a = "Ninety";
                        break;
                }
                switch (num % 10)
                {
                    case 1:
                        b = "one";
                        break;
                    case 2:
                        b = "two";
                        break;
                    case 3:
                        b = "three";
                        break;
                    case 4:
                        b = "four";
                        break;
                    case 5:
                        b = "five";
                        break;
                    case 6:
                        b = "six";
                        break;
                    case 7:
                        b = "sever";
                        break;
                    case 8:
                        b = "eight";
                        break;
                    case 9:
                        b = "nine";
                        break;
                }
            }

            return $"{a} {b}";
        }

        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Task1(a, b));

            //Console.WriteLine(Task2(a, b));

            (double a, double b, double c) result = Task3(a, b, c);
            Console.WriteLine(result);

            //(double x1, double x2) result = Task4(a, b, c);
            //Console.WriteLine(result);

            //Console.WriteLine(Task5(number));
        }
    }
}
