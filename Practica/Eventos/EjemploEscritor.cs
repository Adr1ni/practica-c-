namespace Practica.Eventos
{
    public class EjemploEscritor
    {
        public delegate void EjemploDelegado();
        public event EjemploDelegado ejemploDelegado;

        public void Suma(int n1, int n2)
        {
            if (ejemploDelegado != null)
            {
                Console.WriteLine($"{n1 + n2}");
            }
            else
            {
                Console.WriteLine("Error no esta suscripto al evento");
            }
        }

        public void Restar(int n1, int n2)
        {
            if (ejemploDelegado != null)
            {
                Console.WriteLine($"{n1 - n2}");
            }
            else
            {
                Console.WriteLine("Error no esta suscripto al evento");
            }
        }
    }
}
