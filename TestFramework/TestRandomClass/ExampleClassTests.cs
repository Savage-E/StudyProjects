using RandomClass;
using System;
using TestFramework;

namespace TestRandomClass
{
    [NTestClass]
    public class ExampleClassTests
    {
        private Example temp;

        [NTestMethod]
        public void RightResultofConcatenationOf2Strings()
        {
            temp = new Example();

            string expected = "Hello Mister";

            string result = temp.Concatenation("Hello ", "Mister");

            Console.WriteLine("RightResultofConcatenationOf2Strings : " + Assert<string>.AreEqual(expected, result));
        }

        public void Check_is5positive_TrueReturned()
        {
            temp = new Example();

            bool actual = temp.IsPositiveNumber(5);
            Console.WriteLine("Check_is5positive_TrueReturned : " + Assert<bool>.IsTrue(actual));
        }

        [NTestMethod]
        public void Check_isminus5positive_FalseReturned()
        {
            temp = new Example();

            bool actual = temp.IsPositiveNumber(-5);
            Console.WriteLine("Check_isminus5positive_FalseReturned : " + Assert<bool>.IsTrue(actual));
        }

        [NTestMethod]
        public void Multiply_5x5_25Reterned()
        {
            temp = new Example();

            double expected = 25;

            double actual = temp.Multiplicaton(5, 5);

            Console.WriteLine("Multiply_5x5_25Reterned : " + Assert<double>.AreEqual(expected, actual));
        }

        [NTestMethod]
        public void Multiply_0x5_0Reterned()
        {
            temp = new Example();

            double expected = 0;

            double actual = temp.Multiplicaton(0, 5);

            Console.WriteLine("Multiply_0x5_0Reterned : " + Assert<double>.AreEqual(expected, actual));
        }

        [NTestMethod]
        public void Findmaxel_54ismaxelement_54Reterned()
        {
            temp = new Example();
            int[,] m = new int[,] { { 4, 3, 1 }, { 44, 3, -1 }, { 54, 11, 13 } };

            int expected = 54;

            int actual = temp.MaxElement(m);

            Console.WriteLine("Findmaxel_54ismaxelement_54Reterned: " + Assert<int>.AreEqual(expected, actual));
        }
    }

    [NTestClass]
    public class Forexample
    {
        private Example temp;

        [NTestMethod]
        public void Show()
        {
            Console.WriteLine("Forexample Called");
        }

        [NTestMethod]
        public void Multiply_2x5_10Reterned()
        {
            temp = new Example();

            double expected = 10;

            double actual = temp.Multiplicaton(2, 5);

            Console.WriteLine("Multiply_2x5_10Reterned : " + Assert<double>.AreEqual(expected, actual));
        }
    }
}