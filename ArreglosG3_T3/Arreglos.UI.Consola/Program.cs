
using Arreglos.Logica;
Console.WriteLine("Arreglos\n");
//----------------------------------
MiArreglo miArreglo = new(5);
miArreglo.Agregar(3);
miArreglo.Agregar(5);
    miArreglo.Agregar(7) ;
miArreglo.Insertar(2, 0);
Console.WriteLine(miArreglo);
Console.WriteLine("-----------------------------");
miArreglo.Eleminar(1);
Console.WriteLine(miArreglo);
//----------------------------------
//try
//{
//    for (int i = 0; i < miArreglo.N; i++) { 
//    miArreglo.Agregar(i*6);
//    }
//Console.WriteLine(miArreglo);

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);

//}

//Console.WriteLine("Arreglos");
//MiArreglo oMyarreglo = new(10);
//oMyarreglo.Llenar(1,10);
//oMyarreglo.ToString();
//Console.WriteLine("\nArreglo desordenado");
//Console.WriteLine(oMyarreglo.ToString());

//Console.WriteLine("\nArreglo ordenado Asendente");
//oMyarreglo.Ordenar();
//Console.WriteLine(oMyarreglo.ToString());

//Console.WriteLine("\nArreglo ordenado desendente");
//oMyarreglo.Ordenar(false);
//Console.WriteLine(oMyarreglo.ToString());
Console.ReadKey();
