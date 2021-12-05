using System;

namespace HomeWork2
{
    class Program
    {
        static void Task1(double a, double b)
        {
            if (a > b)
            {
                Console.WriteLine($"Result: {a + b}");
            }
            else if (a == b)
            {
                Console.WriteLine($"Result: {a * b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"Result: {a - b}");
            }
        }

        static void Task2(double x, double y)
        {
            if(x > 0 && y > 0)
            {
                Console.WriteLine($"I quarter");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"II quarter");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"III quarter");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"IV quarter");
            }
            else
            {
                Console.WriteLine($"Zero or on the line");
            }
        }

        static void Task3(double a, double b, double c)
        {
            if (a < b && a < c)
            {
                Console.WriteLine(a);
                if (b < c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b);
                if (a < c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
            }
            else if (c < a && c < b)
            {
                Console.WriteLine(c);
                if (a < b)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
            }
        }

        static void Task4(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            double x1;
            double x2;
            if (discriminant >= 0)
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
            }
            else
            {
                Console.WriteLine("No result");
            }
        }

        static void Task5(int num)
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

            Console.WriteLine($"Result: {a} {b}");
        }

        static void Main(string[] args)
        {
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());
            int number = Convert.ToInt32(Console.ReadLine());

            //Task1(a, b);
            //Task2(a, b);
            //Task3(a, b, c);
            //Task4(a, b, c);
            Task5(number);
        }
    }
}
