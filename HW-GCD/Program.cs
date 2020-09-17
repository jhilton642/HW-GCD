using System;

namespace HW_GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an int");
            string tNum1 = Console.ReadLine();
            int num1 = Convert.ToInt32(tNum1);
            Console.WriteLine("Enter another int");
            string tNum2 = Console.ReadLine();
            int num2 = Convert.ToInt32(tNum2);
            while (true)
            {
                if (num2 > num1)
                {
                    int temp = num1;
                    num1 = num2;
                    num2 = temp;
                }
                    if (num1 % num2 == 0)
                    {
                        Console.WriteLine("The GCD is: " + num2);
                        break;
                    }
                    else
                    {
                        int temp2 = num1;
                        num1 = num2;
                        num2 = temp2 % num2;
                        continue;
                    }
                }
            }
        }
    }

