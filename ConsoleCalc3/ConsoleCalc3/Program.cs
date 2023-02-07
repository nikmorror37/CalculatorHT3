using System.Data;
using System.Globalization;

namespace ConsoleCalc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
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