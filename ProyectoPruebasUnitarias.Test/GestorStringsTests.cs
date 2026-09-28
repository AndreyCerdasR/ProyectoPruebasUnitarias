using NUnit.Framework;

namespace ProyectoPruebasUnitarias.Test
{
    public class GestorStringsTests
    {
        [Test]
        public void Concatenar_DosStrings_RetornaConcatenacion()
        {
            // Arrange
            var gestor = new GestorStrings();

            // Act
            var resultado = gestor.Concatenar("Hola", "Mundo");

            // Assert
            Assert.AreEqual("HolaMundo", resultado);
        }

        [Test]
        public void Longitud_String_RetornaCorrecto()
        {
            // Arrange
            var gestor = new GestorStrings();

            // Act
            var resultado = gestor.Longitud("Test");

            // Assert
            Assert.AreEqual(4, resultado);
        }

        [Test]
        public void Lista_AgregarElemento_ContieneElemento()
        {
            var lista = new List<int>();
            lista.Add(10);
            Assert.Contains(10, lista);
        }

        [Test]
        public void Concatenar_ParametroNulo_RetornaSoloElOtro()
        {
            var gestor = new GestorStrings();
            Assert.AreEqual("Hola", gestor.Concatenar("Hola", null));
        }
    }
}
