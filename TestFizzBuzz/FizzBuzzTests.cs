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

            string resultat = FizzBuzz.JeuFizzBuzz(nombre);

            Assert.AreEqual("Fizz", resultat);
            
        }

        [TestMethod]
        public void BuzzSiNombreEgal5()
        {
            int nombre = 5;

            string resultat = FizzBuzz.JeuFizzBuzz(nombre);

            Assert.AreEqual("Buzz", resultat);
        }
        [TestMethod]
        public void ErrorSiNombreEgal0()
        {
            int nombre = 0;

            string resultat = FizzBuzz.JeuFizzBuzz(nombre);

            Assert.AreEqual("Error", resultat);
        }
        
        [TestMethod]
        public void ErrorSiNombreEstNegatif()
        {
            int nombre = -1;

            string resultat = FizzBuzz.JeuFizzBuzz(nombre);

            Assert.AreEqual("Error", resultat);
        }

        [TestMethod]
        public void FizzSiMultipleDe3()
        {

            int nombre = 6;

            string resultat = FizzBuzz.JeuFizzBuzz(nombre);

            Assert.AreEqual("Fizz", resultat);
        }

    }
}
