namespace ProyectoPruebasUnitarias
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Persona otra)
                return Nombre == otra.Nombre && Edad == otra.Edad;
            return false;
        }

        public override int GetHashCode() => (Nombre, Edad).GetHashCode();
    }
}
