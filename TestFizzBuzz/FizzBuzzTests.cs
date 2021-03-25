using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BaseFizzBuzz;

namespace TestFizzBuzz
{
    [TestClass]
    public class FizzBuzzTests
    {

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

            int nombre = 9;

            string resultat = FizzBuzz.JeuFizzBuzz(nombre);

            Assert.AreEqual("Fizz", resultat);
        }
        [TestMethod]
        public void BuzzSiMultipleDe5()
        {

            int nombre = 10;

            string resultat = FizzBuzz.JeuFizzBuzz(nombre);

            Assert.AreEqual("Buzz", resultat);
        }

        [TestMethod]
        public void FizzBuzzSi15()
        {

            int nombre = 15;

            string resultat = FizzBuzz.JeuFizzBuzz(nombre);

            Assert.AreEqual("FizzBuzz", resultat);
        }
        [TestMethod]
        public void FizzBuzzSiMultiple3et5()
        {

            int nombre = 30;

            string resultat = FizzBuzz.JeuFizzBuzz(nombre);

            Assert.AreEqual("FizzBuzz", resultat);
        }

    }
}
