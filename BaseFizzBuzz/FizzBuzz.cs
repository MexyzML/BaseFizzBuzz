using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaseFizzBuzz
{
    public class FizzBuzz
    {
        public static void Main() { }

        public static string JeuFizzBuzz(int nombre)
        {
        
            if (nombre <= 0)
            {
                return "Error";
            }
            else if (nombre%3 == 0)
            {
                return "Fizz";
            }
            else if(nombre == 5)
            {
                return "Buzz";
            }
            else
            {
                return null;
            }
        }
    }
}
