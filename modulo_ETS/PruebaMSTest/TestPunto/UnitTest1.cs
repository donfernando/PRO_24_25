using mio;

namespace TestPunto
{
    [TestClass]
    public class UnitTestPunto1
    {
        Punto puntoDefecto;
        Punto punto4_45;

        [TestInitialize]
        public void TestInit()
        {
            puntoDefecto = new Punto();
            punto4_45 = new Punto(4,45);
        }
        [TestMethod]
        public void TestMethod1()
        {
            puntoDefecto.x = 5;
            Assert.AreEqual(new Punto(5, 1), puntoDefecto);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(new Punto(1, 1), puntoDefecto);
        }
    }
}