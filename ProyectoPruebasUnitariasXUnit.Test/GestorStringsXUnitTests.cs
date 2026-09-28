using ProyectoPruebasUnitarias;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPruebasUnitariasXUnit.Test
{
    public class GestorStringsXUnitTests
    {
        [Fact]
        public void Concatenar_DosStrings_RetornaConcatenacion()
        {
            // Arrange
            var gestor = new GestorStrings();

            // Act
            var resultado = gestor.Concatenar("Hola", "Mundo");

            // Assert
            Assert.Equal("HolaMundo", resultado);
        }

        [Fact]
        public void Longitud_String_RetornaCorrecto()
        {
            // Arrange
            var gestor = new GestorStrings();

            // Act
            var resultado = gestor.Longitud("Test");

            // Assert
            Assert.Equal(4, resultado);
        }

        [Fact]
        public void Lista_AgregarElemento_ContieneElemento()
        {
            var lista = new List<int>();
            lista.Add(10);
            Assert.Contains(10, lista);
        }

        [Fact]
        public void Concatenar_ParametroNulo_RetornaSoloElOtro()
        {
            var gestor = new GestorStrings();
            Assert.Equal("Hola", gestor.Concatenar("Hola", null));
        }
    }
}
