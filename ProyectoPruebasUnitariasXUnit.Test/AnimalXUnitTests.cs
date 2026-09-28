using ProyectoPruebasUnitarias;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPruebasUnitariasXUnit.Test
{
    public class AnimalXUnitTests
    {
        [Fact]
        public void Perro_Hablar_RetornaGuau()
        {
            // Arrange
            var perro = new Perro();

            // Act
            var resultado = perro.Hablar();

            // Assert
            Assert.Equal("Guau", resultado);
        }

        [Fact]
        public void Animal_Hablar_RetornaSonidoGenerico()
        {
            // Arrange
            var animal = new Animal();

            // Act
            var resultado = animal.Hablar();

            // Assert
            Assert.Equal("Sonido genérico", resultado);
        }

        [Fact]
        public void Animales_Hablar_DiferentesSonidos()
        {
            var animales = new List<Animal> { new Animal(), new Perro() };
            Assert.Equal("Sonido genérico", animales[0].Hablar());
            Assert.Equal("Guau", animales[1].Hablar());
        }
    }
}
