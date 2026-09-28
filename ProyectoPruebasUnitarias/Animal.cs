namespace ProyectoPruebasUnitarias
{
    public class Animal
    {
        public virtual string Hablar() => "Sonido genérico";
    }

    public class Perro : Animal
    {
        public override string Hablar() => "Guau";
    }
}
