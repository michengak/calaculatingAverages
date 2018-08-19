using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatingAverages_Exercise2A
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            double sum = 0;

            double number;

            for (double i = 0; i < 10; i++) 
            {
                Console.Write("Enter number " + (i  + 1) + " between 0 - 100: " );

                number = Convert.ToDouble(Console.ReadLine());

                if (number >= 0 && number <= 100)
                    sum += number;
                else
                    Console.WriteLine("Enter a valid number:");
            }

            Console.WriteLine("Your total number is : " + sum);
            
        }      
            
   
                    
           











    
    
    }       
    
           
}
