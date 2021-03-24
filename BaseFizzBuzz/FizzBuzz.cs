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

        public static string IsFizzOrBuzz(int nombre)
        {
            if (nombre == 3)
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
