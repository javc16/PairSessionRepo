using System;

namespace PairSessionRepo
{
    public class Program
    {

        
        static void Main(string[] args)
        {
            decimal firstNumber;
            decimal secondNumber;

            Console.WriteLine("Enter first value");
            firstNumber = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter second value");
            secondNumber = decimal.Parse(Console.ReadLine());


            TestingCode p = new TestingCode();
            Console.WriteLine("The answer is: " +p.sum(firstNumber, secondNumber));
       
        }
    }
}
