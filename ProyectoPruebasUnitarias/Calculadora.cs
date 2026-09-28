namespace ProyectoPruebasUnitarias
{
    public class Calculadora
    {
        public int SumarNumeros(int a, int b)
        {
            checked
            {
                return a + b;
            }
        }
        public int RestarNumeros(int a, int b) => a - b;
    }
}
