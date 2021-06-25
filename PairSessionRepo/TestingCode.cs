using System;
using System.Text.RegularExpressions;

namespace PairSessionRepo
{
    public class TestingCode
    {
        public decimal sum(decimal firstNumber, decimal secondNumber)
        {
            var result = firstNumber + secondNumber;
            if (result > 9) 
            {
                throw new NotImplementedException("We only allow operations of one digit result") ;
            }

            return result;
        }

       
    }
}
