
using Arreglos.Logica;

Console.WriteLine("Arreglos");
MiArreglo oMyarreglo = new(10);
oMyarreglo.Llenar(1,10);
oMyarreglo.ToString();
Console.WriteLine("\nArreglo desordenado");
Console.WriteLine(oMyarreglo.ToString());

Console.WriteLine("\nArreglo ordenado Asendente");
oMyarreglo.Ordenar();
Console.WriteLine(oMyarreglo.ToString());

Console.WriteLine("\nArreglo ordenado desendente");
oMyarreglo.Ordenar(false);
Console.WriteLine(oMyarreglo.ToString());
Console.ReadKey();
