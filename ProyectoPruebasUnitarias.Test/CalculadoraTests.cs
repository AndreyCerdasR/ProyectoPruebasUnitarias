using NUnit.Framework;

namespace ProyectoPruebasUnitarias.Test
{
    public class CalculadoraTests
    {
        private Calculadora calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculadora();
        }

        [Test]
        public void Sumar_DosNumeros_RetornaResultadoCorrecto()
        {
            // Arrange
            int a = 2, b = 3;

            // Act
            var resultado = calc.SumarNumeros(a, b);

            // Assert
            Assert.AreEqual(5, resultado);
        }

        [Test]
        public void Restar_DosNumeros_RetornaResultadoCorrecto()
        {
            // Arrange
            int a = 3, b = 2;

            // Act
            var resultado = calc.RestarNumeros(a, b);

            // Assert
            Assert.AreEqual(1, resultado);
        }

        [Test]
        public void SumarNumeros_Overflow_LanzaOverflowException()
        {
            // Arrange
            var calc = new Calculadora();

            // Act & Assert
            Assert.Throws<OverflowException>(() =>
            {
                calc.SumarNumeros(int.MaxValue, 1); 
            });
        }

        [TestCase(2, 3, 5)]
        [TestCase(-1, -1, -2)]
        [TestCase(0, 10, 10)]
        public void Sumar_VariosCasos_RetornaCorrecto(int a, int b, int esperado)
        {
            var calc = new Calculadora();
            Assert.AreEqual(esperado, calc.SumarNumeros(a, b));
        }
    }
}
