using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaseFizzBuzz
{
    public class FizzBuzz
    {
        static void Main(string[] args)
        {
            
            while (true)
            {


                Console.WriteLine("Rentrez un nombre : ");
                string entree = Console.ReadLine();
                int nombre;
                Int32.TryParse(entree, out nombre);

                Console.WriteLine(JeuFizzBuzz(nombre));

            }
            
        }


        public static string JeuFizzBuzz(int nombre)
        {

            if (nombre <= 0)
            {
                return "Error";
            }
            else if (nombre % 3 == 0 && nombre % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (nombre%3 == 0)
            {
                return "Fizz";
            }
            else if(nombre%5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return nombre.ToString();
            }
        }
    }
}
