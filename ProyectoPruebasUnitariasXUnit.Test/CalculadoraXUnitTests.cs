using ProyectoPruebasUnitarias;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPruebasUnitariasXUnit.Test
{
    public class CalculadoraXUnitTests
    {
        private readonly Calculadora calc;

        public CalculadoraXUnitTests()
        {
            calc = new Calculadora();
        }

        [Fact]
        public void Sumar_DosNumeros_RetornaResultadoCorrecto()
        {
            // Arrange
            int a = 2, b = 3;

            // Act
            var resultado = calc.SumarNumeros(a, b);

            // Assert
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Restar_DosNumeros_RetornaResultadoCorrecto()
        {
            // Arrange
            int a = 3, b = 2;

            // Act
            var resultado = calc.RestarNumeros(a, b);

            // Assert
            Assert.Equal(1, resultado);
        }

        [Fact]
        public void SumarNumeros_Overflow_LanzaOverflowException()
        {
            // Arrange
            var calc = new Calculadora();

            // Act & Assert
            Assert.Throws<OverflowException>(() =>
            {
                checked { calc.SumarNumeros(int.MaxValue, 1); }
            });
        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-1, -1, -2)]
        [InlineData(0, 10, 10)]
        public void Sumar_VariosCasos_RetornaCorrecto(int a, int b, int esperado)
        {
            // Act
            var resultado = calc.SumarNumeros(a, b);

            // Assert
            Assert.Equal(esperado, resultado);
        }
    }
}
