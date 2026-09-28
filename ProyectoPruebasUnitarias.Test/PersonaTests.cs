using NUnit.Framework;

namespace ProyectoPruebasUnitarias.Test
{
    public class PersonaTests
    {
        [Test]
        public void Persona_IgualdadObjetos_RetornaTrue()
        {
            // Arrange
            var p1 = new Persona { Nombre = "Ana", Edad = 25 };
            var p2 = new Persona { Nombre = "Ana", Edad = 25 };

            // Act
            var sonIguales = p1.Equals(p2);

            // Assert
            Assert.IsTrue(sonIguales);
        }
    }
}
