using MiniExamen;
namespace MSTest
{
    [TestClass]
    public class UTestEjercicio01
    {
        [TestMethod]
        public void TestEstaOrdenado_Vacio()
        {
            bool obtenido = Ejercicio.EstaOrdenado(new int[0]);
            Assert.IsTrue(obtenido);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestEstaOrdenado_Null()
        {
            Ejercicio.EstaOrdenado(null);
        }
        [TestMethod]
        [DataRow(new int[] { 14, 12 })]
        [DataRow(new int[] { 32, 14 })]
        [DataRow(new int[] { 14, 12, 12 })]
        public void TestEstaOrdenado_EsTrue_01(int[] datos)
        {
            bool obtenido = Ejercicio.EstaOrdenado(datos);
            Assert.IsTrue(obtenido);
            //Assert.AreEqual(true, obtenido);
        }
    }
}