using NUnit.Framework;
using SafariParkApp;

namespace SafariPark_Tests
{
    public class Airplane_Tests
    {
        [Test]
        public void GivenADistance_Ascend_IncreasesAltitudeByThatAmount()
        {
            Airplane spitfire = new Airplane(200);
            var result = spitfire.Ascend(500);
            Assert.AreEqual(result, 500);
        }
        [Test]
        public void GivenADistance_Descend_DecreasesAltitudeByThatAmount()
        {
            Airplane spitfire = new Airplane(200);
            var result = spitfire.Descend(200);
            Assert.AreEqual(result, 300);
        }
        [Test]
        public void WhenParameterlessMoveIsCalled_ReturnsCorrectString()
        {
            Airplane spitfire = new Airplane(200);
            var result = spitfire.Move();
            Assert.AreEqual(result, $"Moving along at an altitude of {spitfire.Altitude} metres");
        }
        [Test]
        public void GivenANumberOfTimes_Move_ReturnsCorrectString()
        {
            Airplane spitfire = new Airplane(200);
            var result = spitfire.Move(3);
            Assert.AreEqual(result, $"Moving along 3 times at an altitude of {spitfire.Altitude} metres");
        }
        [Test]
        public void WhenCalled_ToString_ReturnsCorrectString_WithCorrectPositionAndAltitude()
        {
            Airplane spitfire = new Airplane(200);
            var result = spitfire.ToString();
            Assert.AreEqual(result, $"Thank you for flying JetsRUs: {base.ToString()} capacity: 200 passengers: speed: 100 position: {spitfire.Position} altitude: {spitfire.Altitude}");
        });
        }

    }
}
