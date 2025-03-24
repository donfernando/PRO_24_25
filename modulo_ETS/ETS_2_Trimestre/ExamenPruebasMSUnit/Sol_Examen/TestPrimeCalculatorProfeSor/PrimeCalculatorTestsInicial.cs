namespace TestPrimeCalculatorProfeSor;
using MSUnit_ProfeSor;

[TestClass]
public class PrimeCalculatorTestsInicial {
    [TestMethod]
    [DataRow(13, true)]
    [DataRow(9, false)]
    [DataRow(1, false)]
    [DataRow(0, false)]
    public void TestPrimeCalculator(int num, bool esperado) {
        bool esprimo = PrimeCalculatorProfeSor.IsPrime(num);
        Assert.AreEqual(esprimo, esperado);
    }
    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void PruebaExcepcion() {
        PrimeCalculatorProfeSor.IsPrime(int.MaxValue);
    }
}