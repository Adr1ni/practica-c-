namespace Practica.Delegados
{
    public class EjemploDelegados
    {
        private void Imprimir(string value)
        {
            Console.WriteLine(value);
        }

        public void EjemploAction()
        {
            //Definimos el valor de salida
            Action<string> imprimirAction = Imprimir;
            imprimirAction("Ejemplo de delegado Action");
        }

        public void EjemploFunct(int num1, int num2)
        {
            //Podemos definir el los valores de entrada y salida
            Func<int, int, string> imprimirFunc = (n1, n2) => $"Resultado suma {n1 + n2}";
            Console.WriteLine(imprimirFunc(num1, num2));
        }

        public void EjemploPredicate(int edad)
        {
            //Siempre retorna un valor bool
            Predicate<int> mayorEdad = e => e >= 18;
            Console.WriteLine(mayorEdad(edad));
        }
    }
}
