using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairSessionRepo
{
    public class TestingCode
    {
        public decimal sum(decimal firstNumber, decimal secondNumber)
        {
            var result = firstNumber + secondNumber;
            if (result > 10) 
            {
                throw new NotImplementedException("We only allow operations of one digit") ;
            }

            return result;
        }
    }
}
