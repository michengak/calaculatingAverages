using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average10Scores
{
    class average10Scores

    {
        static void Main(string[] args)
        {

            double sum = 0;

            double number;
            double average;

            for (double i = 0; i < 10; i++)
            {
                Console.Write("Enter number " + (i + 1) + " between 0 - 100: ");

                number = Convert.ToDouble(Console.ReadLine());

                if (number >= 0 && number <= 100)
                    sum += number;
                else
                    Console.WriteLine("Enter a valid number:");
            }

                  Console.WriteLine("Your total number is : " + sum + " and Your average grade is: " + sum / 10);
           
            
            

            if ((sum / 10) >= 90 && (sum / 10) <= 100)

                Console.WriteLine("Your grade is : A");

            else if ((sum / 10) >= 80 && (sum / 10) <= 89)

                Console.WriteLine("Your grade is : B");

            else if ((sum / 10) >= 70 && (sum / 10) <= 79)

                Console.WriteLine("Your grade is : C");

            else if ((sum / 10) >= 60 && (sum / 10) <= 69)

                Console.WriteLine("Your grade is : C");

            else Console.WriteLine(" Your grade is : F");




        }
    }
}
