using System.Security.AccessControl;
using System.Xml;

// static void saludar(string mensaje){
//     Console.WriteLine("Hola como estas "+mensaje);
// }

// saludar("Carlos");


// METODO SALUDAR Y DESPEDIR

// static void SaludarDespedir(string nom,string mensaje){
//     if (mensaje=="hola")
//     {
//         Console.WriteLine($"Hola {nom}, como estas?");
//     }else if (mensaje=="chao")
//     {
//         Console.WriteLine($"Chao {nom}, hasta luego");
//     }
// }

// Console.WriteLine("Digite su nombre");
// string nom=Console.ReadLine();
// Console.WriteLine("Digite un hola, o un chao");
// string mensaje=Console.ReadLine();

// SaludarDespedir(nom,mensaje);

// METODO SUMA

// static void suma(int num, int num1){
//     Console.WriteLine($" La suma de los numeros es: {num+num1} ");
// }

// Console.WriteLine("Digite el primer numero de la suma");
// int a=int.Parse(Console.ReadLine());
// Console.WriteLine("Digite el otro numero de la suma");
// int b=int.Parse(Console.ReadLine());
// suma(a,b);

// METODO RESTA

// static void resta(int num, int num1){
//     Console.WriteLine($" La resta de los numeros es: {num-num1} ");
// }

// Console.WriteLine("Digite el primer numero de la resta");
// int a=int.Parse(Console.ReadLine());
// Console.WriteLine("Digite el otro numero de la resta");
// int b=int.Parse(Console.ReadLine());
// resta(a,b);

// METODO DIVIR

// static void dividir(int num, int num1){
//     Console.WriteLine($" La division de los numeros es: {num/num1} ");
// }

// Console.WriteLine("Digite el primer numero de la dividir");
// int a=int.Parse(Console.ReadLine());
// Console.WriteLine("Digite el otro numero de la dividir");
// int b=int.Parse(Console.ReadLine());
// dividir(a,b);

// // METODO MULTIPLICAR

// static void multiplicar(int num, int num1){
//     Console.WriteLine($" La multiplicacion de los numeros es: {num*num1} ");
// }

// Console.WriteLine("Digite el primer numero de la multiplicar");
// int a=int.Parse(Console.ReadLine());
// Console.WriteLine("Digite el otro numero de la multiplicar");
// int b=int.Parse(Console.ReadLine());
// multiplicar(a,b);

// METODO PAR IMPAR

// static void parimp(int num){
//     if (num%2==0)
//     {
//         Console.WriteLine($"El numero {num} es par");
//     }else{
//         Console.WriteLine($"El numero {num} es impar");
//     }
// }

// Console.WriteLine("Digite un numero");
// int num=int.Parse(Console.ReadLine());

// parimp(num);

// METODO PRIMOS

// static void primos(int num){
// int cont=0;
//     for (int i = num; i > 0; i--)
//     {
//         if (num%i==0)
//         {
//             cont+=1;
//         }
//     }
//     if (cont==2)
//     {
//         Console.WriteLine($"El numero {num} es primo");
//     }else{
//         Console.WriteLine($"El numero {num} no es primo");
//     }
// }

// Console.WriteLine("Digite un numero");
// int num=int.Parse(Console.ReadLine());

// primos(num);

// LISTA

// List<int> numero= new List<int>();
// numero.Add(5);
// numero.Add(41);
// numero.Add(5);
// foreach (int i in numero)
// {
//     Console.WriteLine(i);
// }

// LISTA CON DOS VARIABLES

// List<(int, string)> numero = new List<(int,string)>();
// numero.Add((5, "hola"));
// numero.Add((41, "como estas"));
// numero.Add((5, "lala"));
// foreach ((int i, string a) in numero)
// {
//     Console.WriteLine(i+a);
// }


// List<int> numero= new List<int>();
// numero.Add(5);
// numero.Add(41);
// numero.Add(5);
// foreach (int i in numero)
// {
//     Console.WriteLine($"el numero es: {i}");
// }

// numero.Remove(41);
// foreach(int i in numero)
// {
//     Console.WriteLine(i);
// }

// Orden alfabetico


// List <string> nombre = new List<string>();
// nombre.Add("Sebas");
// nombre.Add("Anfer");
// nombre.Add("Leo");
// nombre.Add("Luis");
// nombre.Add("Juan");
// nombre.Sort();
// foreach (string i in nombre)
// {
//     Console.WriteLine(i);
// }


// LISTAS

// List <string> nombre = new List<string>();
// nombre.Add("Sebas");
// nombre.Add("Anfer");
// nombre.Add("Leo");
// nombre.Add("Luis");
// nombre.Add("Juan");
// foreach (string a in nombre)
// {
//     Console.WriteLine($"Su nombre es: {a}");
// }

// List<string> apellido=new List<string>();
// apellido.Add("Perez");
// apellido.Add("Salazar");
// apellido.Add("Gutierrez");
// apellido.Add("Marin");
// apellido.Add("Reyes");
// foreach (string b in apellido)
// {
//     Console.WriteLine($"Su apellido es: {b}");
// }

// List<int> tell=new List<int>();
// tell.Add(1234);
// tell.Add(4321);
// tell.Add(2314);
// tell.Add(5127);
// tell.Add(9987);
// foreach (int c in tell)
// {
//     Console.WriteLine($"Su telefono es: {c}");
// }


//     Console.WriteLine("╔═════════════════════════════════╗");
//     Console.WriteLine("║          MENU PRINCIPAL         ║");
//     Console.WriteLine("╠═════════════════════════════════╣");
//     Console.WriteLine("║    1.Agregar                    ║");
//     Console.WriteLine("║    2.Eliminar                   ║");
//     Console.WriteLine("║    3.Buscar                     ║");
//     Console.WriteLine("╠═════════════════════════════════╣");
//     Console.WriteLine("║       Seleccione una opcion( )  ║");
//     Console.WriteLine("╚═════════════════════════════════╝");
//     Console.Write("Digite la opcion:");
//   int op=int.Parse(Console.ReadLine());

//     Console.WriteLine("╔═════════════════════════════════╗");
//     Console.WriteLine("║          MENU PRINCIPAL         ║");
//     Console.WriteLine("╠═════════════════════════════════╣");
//     Console.WriteLine("║    1.Nombre                     ║");
//     Console.WriteLine("║    2.Apellido                   ║");
//     Console.WriteLine("║    3.Telefono                   ║");
//     Console.WriteLine("╠═════════════════════════════════╣");
//     Console.WriteLine("║       Seleccione una opcion( )  ║");
//     Console.WriteLine("╚═════════════════════════════════╝");
//   Console.WriteLine("Digite el nombre de la lista");
//   int nom=int.Parse(Console.ReadLine());

//   if (op == 1 && nom == 1)
//   {
//     Console.WriteLine("Que valor deceas agregar?");
//     string val=Console.ReadLine();
//     nombre.Add(val);
//     foreach (string a in nombre)
//     {
//         Console.WriteLine(a);
//     }
//   }else if (op==2 && nom==1)
//   {
//     Console.WriteLine("Que valor deceas eliminar?");
//     string val=Console.ReadLine();
//     nombre.Remove(val);
//     foreach (string a in nombre)
//     {
//         Console.WriteLine(a);
//     }
//   }else if (op==3 && nom==1)
//   {
//     Console.WriteLine("Que valor deceas buscar?");
//     string val=Console.ReadLine();
//     int indice=nombre.FindIndex(value => value == val);
//     if (indice!=-1)
//     {
//         Console.WriteLine($"El valor {val} se encuentra en el indice {indice} de la lista");
//     }else{
//         Console.WriteLine("No se encontro lo que buscas.");
//     }
//   }
  
//   else if (op == 1 && nom == 2)
//   {
//     Console.WriteLine("Que valor deceas agregar?");
//     string val=Console.ReadLine();
//     apellido.Add(val);
//     foreach (string b in apellido)
//     {
//         Console.WriteLine(b);
//     }
//   } else if (op==2 && nom==2)
//   {
//     Console.WriteLine("Que valor deceas eliminar?");
//     string val=Console.ReadLine();
//     apellido.Remove(val);
//     foreach (string b in apellido)
//     {
//         Console.WriteLine(b);
//     }
//   }else if (op==3 && nom==2)
//   {
//     Console.WriteLine("Que valor deceas buscar?");
//     string val=Console.ReadLine();
//     int indice = apellido.FindIndex(value => value==val);
//         if (indice!=-1)
//         {
//         Console.WriteLine($"EL valor {val} se encuentra en el indice {indice} de la lista");
//         }else{
//             Console.WriteLine("No se encontro lo que buscas.");
//         }
//   }
  
//   else if (op == 1 && nom == 3)
//   {
//     Console.WriteLine("Que valor deceas agregar?");
//     int val=int.Parse(Console.ReadLine());
//     tell.Add(val);
//     foreach (int c in tell)
//     {
//         Console.WriteLine(c);
//     }
//   } else if (op==2 && nom==3)
//   {
//     Console.WriteLine("Que valor deceas eliminar?");
//     int val=int.Parse(Console.ReadLine());
//     tell.Remove(val);
//     foreach (int c in tell)
//     {
//         Console.WriteLine(c);
//     }
//   }else if (op==3 && nom==3)
//   {
//     Console.WriteLine("Que valor deceas buscar?");
//     int val=int.Parse(Console.ReadLine());
//     int indice =tell.FindIndex(value=>value==val);
    
//         if (indice!=-1)
//         {
//         Console.WriteLine($"El valor {val} se encuentra en el indice {indice} de la lista");
//         }else{
//             Console.WriteLine("No se encontro lo que buscas.");
//         }
//   }

 








