using NUnit.Framework;
using FizzBuzzApp;
using System;

namespace FizzBuzzTests
{
    public class FizzBuzzShould
    {
        [TestCase(1, "1")]
        [TestCase(7, "7")]
        [TestCase(11, "11")]

        public void GiveOne_Return_OneString(int input, string output)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo(output));
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void GivenANumberDivisibleByThree_Return_Fizz(int input)
        {
            String expected = Program.FizzBuzz(input);
            Assert.That(expected, Is.EqualTo("Fizz"));
        }

        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void GivenANumberDivisibleByFive_Return_Buzz(int input)
        {
            String expected = Program.FizzBuzz(input);
            Assert.That(expected, Is.EqualTo("Buzz"));
        }
        [TestCase(15)]
        [TestCase(30)]
        public void GivenANumberDivisbleByFifteen_Return_FizzBuzz(int input)
        {
            String expected = Program.FizzBuzz(input);
            Assert.That(expected, Is.EqualTo("FizzBuzz"));
        }
    }
}
