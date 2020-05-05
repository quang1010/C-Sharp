using System;
using System.Text;
using System.Collections.Generic;
using System.Transactions;

namespace baitap
{
    class kiem_tra_so_nguyen_to

    {
        static void Main(string[] args)
        {

            int number;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 2)
                Console.WriteLine($"{number} not is a prime");
            else
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    Console.WriteLine(number + " is a prime");
                }
                else
                {
                    Console.WriteLine(number + " is not a prime");
                }
            }


        







        }









        }
    }

