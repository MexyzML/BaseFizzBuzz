using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BaseFizzBuzz;

namespace TestFizzBuzz
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzSiNombreEgal3()
        {
            int nombre = 3;

            string resultat = FizzBuzz.IsFizzOrBuzz(nombre);

            Assert.AreEqual("Fizz", resultat);
            
        }

        [TestMethod]
        public void BuzzSiNombreEgal5()
        {
            int nombre = 5;

            string resultat = FizzBuzz.IsFizzOrBuzz(nombre);

            Assert.AreEqual("Buzz", resultat);
        }

       
    }
}
