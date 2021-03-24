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

            string resultat = "";

            Assert.AreEqual("Fizz", resultat);
            
        }
    }
}
