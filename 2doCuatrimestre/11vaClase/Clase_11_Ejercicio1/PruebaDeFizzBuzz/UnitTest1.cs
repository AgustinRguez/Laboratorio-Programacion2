using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;
namespace PruebaDeFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FizzBuzz_CuandoEsDivisiblePor3_DeberiaRetornarFizz()
        {
            //Arrange
            int numero = 6;
            string expected = "Fizz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FizzBuzz_CuandoEsDivisiblePor5_DeberiaRetornarBuzz()
        {
            //Arrange
            int numero = 10;
            string expected = "Buzz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FizzBuzz_CuandoEsDivisiblePor3YPor5_DeberiaRetornarFizzBuzz()
        {
            //Arrange
            int numero = 15;
            string expected = "FizzBuzz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FizzBuzz_CuandoNoEsDivisibleNiPor3NiPor5_DeberiaRetornarFizzNumero()
        {
            //Arrange
            int numero = 4;
            string expected = numero.ToString();

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
