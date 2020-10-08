using NUnit.Framework;
using assignment01;

namespace Triangle_Nunit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int x = 3, y = 2, z = 1;
            string Expected_Value = "It is not a triangule!";
            string Actual_Value = TriangleSolver.Analyze(x, y, z);
            Assert.AreEqual(Expected_Value, Actual_Value);
        }
    }
}