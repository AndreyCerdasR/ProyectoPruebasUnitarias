using ProyectoPruebasUnitarias;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPruebasUnitariasXUnit.Test
{
    public class PersonaXUnitTests
    {
        [Fact]
        public void Persona_IgualdadObjetos_RetornaTrue()
        {
            // Arrange
            var p1 = new Persona { Nombre = "Ana", Edad = 25 };
            var p2 = new Persona { Nombre = "Ana", Edad = 25 };

            // Act
            var sonIguales = p1.Equals(p2);

            // Assert
            Assert.True(sonIguales);
        }
    }
}
