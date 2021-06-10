using System;

namespace PairSessionRepo
{
    class Program
    {

        public decimal suma(decimal a, decimal b) 
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            decimal a;
            decimal b;

            Console.WriteLine("Ingrese valor para a");
            a = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese valor para b");
            b = decimal.Parse(Console.ReadLine());


            Program p = new Program();
            Console.WriteLine("La respuesta es: " +p.suma(a, b));
       
        }
    }
}
