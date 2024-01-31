using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Polimorfismo
{
    public class Animal
    {
        public int id { get; set; }
        public string name {  get; set; }
        public int age { get; set; }
        public Animal(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public virtual void Correr()
        {
            Console.WriteLine("El animal corre usando una funcion virtual");
        }

        public void Evolucionar()
        {
            Console.WriteLine("Evoluciona");
        }
    }

    public class Gato : Animal
    {
        public Gato(int id, string name, int age) : base(id, name, age)
        {
        }

        public sealed override void Correr()
        {
            Console.WriteLine("El gato usa la funcion correr con el override y no virtual");
        }
    }

    public class Michi : Gato
    {
        public Michi(int id, string name, int age) : base(id, name, age)
        {
        }
    }
}
