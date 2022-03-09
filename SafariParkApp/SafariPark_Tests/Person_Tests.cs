using NUnit.Framework;
using SafariParkApp;

namespace SafariPark_Tests
{
    public class Person_Tests
    {
        [TestCase("Cathy", "French", "Cathy French")]
        [TestCase("", "", " ")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {
            var subject = new Person(fName, lName);
            //var subject = new Person("A", "B");
            var result = subject.FullName;
            // Older way of doing NUnit Tests:
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B");
            subject.Age = 35;
            Assert.AreEqual(subject.Age, 35);
        }
    }
}