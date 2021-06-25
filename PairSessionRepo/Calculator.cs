using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairSessionRepo
{
    public class Calculator
    {
      

        public int Sum(string number="0")
        {

            int result=0;
            var splitOptions = new char[] { ',', '\n' }; 
            string[] numbers = number.Split(splitOptions);
            foreach (var item in numbers)
            {
                result += Convert.ToInt32(item);
            }
            return result;


        

        }
    }
}
