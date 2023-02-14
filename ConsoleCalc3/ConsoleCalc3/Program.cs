using System.Data;
using System.Globalization;

namespace ConsoleCalc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ДЗ 1-5 было в репозитории Lesson2, еще сюда копипастну если не видели

            /*      //задание ДЗ №5

            Console.Write("Enter the color's number of rainbow: ");

            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Red");
                    break;
                case 2:
                    Console.WriteLine("Orange");
                    break;
                case 3:
                    Console.WriteLine("Yellow");
                    break;
                case 4:
                    Console.WriteLine("Green");
                    break;
                case 5:
                    Console.WriteLine("Light Blue");
                    break;
                case 6:
                    Console.WriteLine("Blue");
                    break;
                case 7:
                    Console.WriteLine("Violet");
                    break;
                default:
                    Console.WriteLine("Write 1-7");
                    break;
            }

            */


            /*      //задание ДЗ №4

            Console.Write("Enter the temperature: ");

            int t = Convert.ToInt32(Console.ReadLine());

            if (t > -5)
            {
                Console.WriteLine("Warm");
            }
            else if (t <= -5 && t > -20)
            {
                Console.WriteLine("Normal");
            }
            else if (t <= -20)
            {
                Console.WriteLine("Cold");
            }

            */


            /*      //задание ДЗ №3

            Console.Write("Enter the number: ");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a %2 == 0)
            {
                Console.WriteLine("This number is EVEN");
            }
            else
            {
                Console.WriteLine("This number is ODD");
            }

            */


            /*      //задание ДЗ №2

            Console.Write("Enter the number of month: ");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1 || a == 2 || a == 12)
            {
                Console.WriteLine("Winter");
            }
            else if (a == 3 || a == 4 || a == 5) 
            {
                Console.WriteLine("Spring");
            }
            else if (a == 6 || a == 7 || a == 8)
            {
                Console.WriteLine("Spring");
            }
            else if (a == 9 || a == 10 || a == 11)
            {
                Console.WriteLine("Spring");
            }
            else 
            {
                Console.WriteLine("Wrong number of month");
            }

            */


            /*              //задание ДЗ №1
            switch (a) 
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    Console.WriteLine("Write 1-12");
                    break;
            }
            */
            while (true)
            {
                Console.WriteLine("\nHello, Nick's 1st console calculator welcomes you ! Read and than choose action \n");
                Console.WriteLine("Press 1 for + ");
                Console.WriteLine("Press 2 for - ");
                Console.WriteLine("Press 3 for / ");
                Console.WriteLine("Press 4 for * ");
                Console.WriteLine("Press 5 for % ");
                Console.WriteLine("Press 6 for ^2 \n");

                Console.Write("Enter your action: ");
                int act = Convert.ToInt32(Console.ReadLine());

                if (act < 1 || act > 6)
                {
                    Console.WriteLine("Wrong number of action");
                    return;
                }

                Console.Write("Write your 1st operand : "); //enter and assign the first input1
                double a = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Write your 2st operand : "); //enter and assign the second input2
                double b = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                double result = 0;

                switch (act)
                {
                    case 1:
                        {
                            result = a + b;
                            Console.WriteLine($"Result of action is {result}");
                            break;
                        }
                    case 2:
                        {
                            result = a - b;
                            Console.WriteLine($"Result of action is {result}");
                            break;
                        }
                    case 3:
                        {
                            result = a / b;
                            if (b == 0)
                            {
                                Console.WriteLine("Error");
                            }
                            else
                            {
                                Console.WriteLine($"Result of action is {result}");
                            }
                            break;
                        }
                    case 4:
                        {
                            result = a * b;
                            Console.WriteLine($"Result of action is {result}");
                            break;
                        }
                    case 5:
                        {
                            result = a / b * 100;
                            if (b == 0)
                            {
                                Console.WriteLine("Error");
                            }
                            else
                            {
                                Console.WriteLine($"Result of action is {result}");
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine(Math.Pow(a, 2));
                            break;
                        }
                }


                Console.Write("Press any button to restart calculations \n");
                Console.WriteLine("If you want to finish, press F");
                ConsoleKeyInfo f = Console.ReadKey();
                if (f.KeyChar == 'f')
                    break;
            }
        }
    }
}