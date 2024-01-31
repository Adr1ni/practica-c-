
namespace Practica.SobrecargaMetodos
{
    public class Suma
    {
        public int sumar(int x, int y)
        {
            return x + y;
        }

        public string sumar(string x, int y)
        {
            return $"La suma{x} de con {y} es: {x + y}";
        }
    }
}
