namespace Practica.Eventos
{
    public class EjemploSuscriptor
    {

        public EjemploEscritor ejemploEscritor;
        private readonly int a;
        private readonly int b;

        public void EjemploEventHandler()
        {
            Console.WriteLine("Se va emitir un evento ----> UwU");
        }

        public EjemploSuscriptor(int a, int b)
        {
            ejemploEscritor = new EjemploEscritor();
            this.a = a;
            this.b = b;

            ejemploEscritor.ejemploDelegado += EjemploEventHandler;
        }

        public void ResultadoSuma()
        {
            ejemploEscritor.Suma(a, b);
        }

        public void ResultadoResta()
        {
            ejemploEscritor.Restar(a, b);
        }
    }
}
