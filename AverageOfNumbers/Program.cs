using System;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace AverageOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            
            {

                for(var idx=1; idx<=30; idx++) //a 'for loop'
                {
                    if(idx%3==0 && idx%5==0)
                        Console.WriteLine("FIZZBUZZ ");
                    else if(idx%3==0 && idx%5!=0)
                        Console.WriteLine("FIZZ ");
                    else if(idx%3!=0 && idx%5==0)
                        Console.WriteLine("BUZZ ");
                    else
                        Console.WriteLine($"{idx} ");


                }


            }

           
          
            
        }
    }
}
