using MyClassLibrary;

namespace TheTester
{
    public class Tests
    {
        private MyServices _myServices;

        [SetUp]
        public void Setup()
        {
            _myServices = new MyServices();
        }

        [Test]
        public void AddTwoIntegers_ReturnAddedNumbers()
        {
            var result = _myServices.AddTwoIntegers(1, 2);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void RollTheDice_ReturnANumberBetweenOneAndSix()
        {
            var result = _myServices.RollTheDice();

            Assert.That(result, Is.InRange(1,6));
        }
    }
}