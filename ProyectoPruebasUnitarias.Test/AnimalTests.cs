using NUnit.Framework;

namespace ProyectoPruebasUnitarias.Test
{
    public class AnimalTests
    {
        [Test]
        public void Perro_Hablar_RetornaGuau()
        {
            // Arrange
            var perro = new Perro();

            // Act
            var resultado = perro.Hablar();

            // Assert
            Assert.AreEqual("Guau", resultado);
        }

        [Test]
        public void Animal_Hablar_RetornaSonidoGenerico()
        {
            // Arrange
            var animal = new Animal();

            // Act
            var resultado = animal.Hablar();

            // Assert
            Assert.AreEqual("Sonido genérico", resultado);
        }

        [Test]
        public void Animales_Hablar_DiferentesSonidos()
        {
            var animales = new List<Animal> { new Animal(), new Perro() };
            Assert.AreEqual("Sonido genérico", animales[0].Hablar());
            Assert.AreEqual("Guau", animales[1].Hablar());
        }
    }
}
