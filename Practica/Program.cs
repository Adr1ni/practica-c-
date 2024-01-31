using Practica.Delegados;
using Practica.Eventos;
using Practica.Generics;
using Practica.Indexers;
using Practica.Linq;
using Practica.Polimorfismo;
using Practica.SobrecargaMetodos;
using Practica.StringExtensions;

var animal = new Animal(1, "Animal1", 12);

animal.Correr();

var gatito = new Gato(2, "kira", 13);

gatito.Correr();

//La clase michi no va heredar la funcion correr debido al sealed que evita la herencia en clases
// o en metodos

//La sobrecarga de metodos defines varios con el mismo nombre pero diferentes parametros, difenrete tipo de 
// retorno como tambien el orden

var suma1 = new Suma();

Console.WriteLine(suma1.sumar(2, 3));
Console.WriteLine(suma1.sumar("2", 3));

//Los extension method nos permiten extender la funcionalidad de un objeto o tipo con metodos estaticos, con 2 
//condiciones: 1. El metodo tiene que ser estatico y el primer parametro debe ir con la palabra reservada this

var frase = "holiii";

var primeraPalabraUpper = frase.FirstLetterUpperCase();

Console.WriteLine(frase);
Console.WriteLine(primeraPalabraUpper);

//Tipos anonimos: una clase sin nombre, quiere decir que no tenemos esa clase en el codigo. 
var developer = new { Nombre = "Adriano", Area = "Fullstack" };

Console.WriteLine(developer);


//Generic crear codigo reusable entre multiples entidades
OperationResult<Car> optResult = new OperationResult<Car>();
optResult.AddMessage("Holiiii");

Console.WriteLine(optResult.Errors[0]);


//Indexers Propiedad que permite a clases o struct ser indexadas como arrays

var stringCollection = new SampleCollection<string>();
stringCollection.Add("Hello, World");
System.Console.WriteLine(stringCollection[0]);


//Linq

IEnumerable<Gato> gatitos = new List<Gato>
{
    new(2,"holi",12),
    new(3,"no",13),
    new(4,"si",16),
    new(5,"talvez",15),
    new(6,"quizas",11),
};

var gatito4 = gatitos.Where(g => g.name == "si");
var orden = gatitos.OrderBy(g => g.age).ToList();

var gatitoSelectNombres = gatitos.Where(g => g.id == 5).Select(g => g.name);

var gatitoFirstDefault = gatitos.FirstOrDefault(g => g.name == "no");

var gatitoFiltro = gatitos.Filtro(a => a.age == 11);

Console.WriteLine(gatitoFirstDefault?.name);
Console.WriteLine(orden);
Console.WriteLine(gatitoSelectNombres);
Console.WriteLine(gatitoFiltro);


//ValueTuple

(string, string, int) alumno = ("Adriano", "Gongora", 19);
Console.WriteLine($"{alumno.Item1} {alumno.Item2} {alumno.Item3}");

(string, string, int) CalcularMoto3()
{
    return ("Honda", "CBR", 2005);
}

(string marcaMoto3, string modeloMoto3, int yearMoto3) = CalcularMoto3();
Console.WriteLine($"la moto es una {marcaMoto3} {modeloMoto3} del año {yearMoto3}");

//Refrencia tipo de valor: Se utliza el objeto como tal en el stack y no un puntero 
//Se hace como una copia del valor a una nueva variable, no se asigna la referencia de memoria de este

int numero = 1;
int numero2 = numero;
numero2 = 2;

Console.WriteLine(numero);
Console.WriteLine(numero2);

//Tipos por referencia: Hace referencia las class y records ubicadas en el heap. La variable en si es un puntero a ese 
//objeto en el heap, no al objeto como tal, quiere que decir que apuntan a lo mismo.

var gato1 = new Gato(1, "asd", 4);
var cat = gato1;

cat.name = "name";

Console.WriteLine(gato1?.name);
Console.WriteLine(cat?.name);

//Colas: primero en entrar primero en salir
Queue<string> marcas = new Queue<string>();
marcas.Enqueue("Audi");
marcas.Enqueue("Opel");
marcas.Enqueue("BMW");

Console.WriteLine(marcas.Count);
Console.WriteLine($"El primer elemento de la cola {marcas.Peek()}");
Console.WriteLine($"El primer elemento de la cola {marcas.Dequeue()} antes de irse");
Console.WriteLine($"La segunda marca es {marcas.Dequeue()}");

//Staqck: last in firts out
Stack<string> stack = new Stack<string>();
stack.Push("asd");
stack.Push("sdf");
stack.Push("jgfjf");

Console.WriteLine(stack.Count);
Console.WriteLine($"Ultimo elemento de la pila {stack.Peek()}");
Console.WriteLine($"Primer elemento en salir de la pila {stack.Pop()}");
Console.WriteLine($"El siguiente elemento de la pila {stack.Peek()}");


//Listas innmutables:
//IReadOnlyList<string> readonlyMarcas = (IReadOnlyList<string>)marcas;
//IList<string> IlistMarcas = (IList<string>)marcas;


//SortedList: Key como indice o elemento a compara por medio del IComparer
SortedList<int, string> listaCochesOrdenada = new SortedList<int, string>()
{
    {3,"bmw" },
    {1, "audi" },
    {2, "opel" }
};

foreach (var item in listaCochesOrdenada)
    Console.WriteLine(item.Value); //imprime: audi, opel, bmw

//Dicctionary
Dictionary<string, string> comunidadesCapitales = new Dictionary<string, string>()
{
    {"Aragon", "Zaragoza"},
    {"Navarra", "Pamplona"}
};
//añadir valores
comunidadesCapitales.Add("Castilla la mancha", "Toledo");

Console.WriteLine(comunidadesCapitales["Aragon"]); //devuelve Zaragoza
KeyValuePair<string, string> resultado = comunidadesCapitales.ElementAt(0);
Console.WriteLine(resultado.Value); //devuelve Zaragoza

//La mejor forma
if (comunidadesCapitales.TryGetValue("asd", out string resultadoCapital))
{
    Console.WriteLine(resultadoCapital); //zaragoza
}
else
{
    Console.WriteLine("el parámetro no existe");
}

//modificar un valor
if (comunidadesCapitales.ContainsKey("Aragon"))
{
    comunidadesCapitales["Aragon"] = "Teruel Existe";
}
comunidadesCapitales.Remove("Aragon");
comunidadesCapitales.Clear();

//PriorityQueue: Permite indicar en que posicion vamos a incluir cada uno de los elementos que equeramos añadir.
//lo representaamos con El primer tipo contendrá nuestro valor, y el segundo tipo es el que va a definir la prioridad.

PriorityQueue<string, int> colaPrioridad = new PriorityQueue<string, int>();
colaPrioridad.Enqueue("Adriano", 3);
colaPrioridad.Enqueue("Pedro", 1);
colaPrioridad.Enqueue("Zule", 2);

string resultPeek = colaPrioridad.Peek();
string resultDequeue = colaPrioridad.Dequeue();
string resultDequeue2 = colaPrioridad.EnqueueDequeue("Mazda", 3);
Console.WriteLine(resultPeek); //Pedro
Console.WriteLine(resultDequeue); //Pedro otra vez
Console.WriteLine(resultDequeue2); //Zule


//Delegados: Referencia a un metodo en un variable(suena redundante pero es para recordar)
var delegado = new EjemploDelegados();
delegado.EjemploAction();
delegado.EjemploFunct(3, 2);
delegado.EjemploPredicate(20);

//Eventos:
EjemploSuscriptor ejemploSuscriptor = new EjemploSuscriptor(3, 2);
ejemploSuscriptor.ResultadoSuma();
ejemploSuscriptor.ResultadoResta();
