namespace AssertSamples.Tests
{
    [TestClass]
    public class MyCLassTests
    {
        [TestMethod]
        public void IsSqrtTest()
        {
            //arrange
            const double input = 4;
            const double expected = 2;
            //act
            double actual = MyClass.GetSqrt(input);
            //assert
            Assert.AreEqual(expected, actual, "Sqrt of {0} should have been {1}!", input, expected);
        }
        [TestMethod]
        public void DeltaTest()
        {
            //arrange
            const double input = 10;
            const double expected = 3.1;
            const double delta = 0.07;

            //3.1622776601683795

            //0.062..
            //act
            double actual = MyClass.GetSqrt(input);

            //assert
            //Перевірка значень на рівність з врахуванням погрішності delta
            Assert.AreEqual(expected, actual, delta, "Fail message !");
        }
        [TestMethod]
        public void StringAreEqualTest()
        {
            //arrange 
            const string input = "HELLO";
            const string expected = "hello";

            //act and assert
            //третій параметр - ігнорування регістру
            Assert.AreEqual(expected, input, true);
        }

        [TestMethod]
        public void StringSameTest()
        {
            string a = "Hello";
            string b = string.Intern("Hello");
            //Перевірка рівності посилань
            Assert.AreSame(a, b);
        }
        [TestMethod]
        public void IntegersSameTest()
        {
            int i = 10;
            int j = 10;
            //Перевірка рівності посилань
            Assert.AreSame(i, j);
        }
    }
}