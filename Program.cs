﻿Console.WriteLine("Diga su animalfavorito");
String animal = Console.ReadLine();
int animalfavorito;
String nombre;
Console.WriteLine("Diga su nombre");
 nombre = Console.ReadLine();

do {
  Console.WriteLine("su animal favorito es ");
   Console.WriteLine("1: Gato");
   Console.WriteLine("2: Perro");
   Console.WriteLine("3: Caballo");
   Console.WriteLine("4: Lobo");
   Console.WriteLine("5: cerdo");
   Console.WriteLine("6: Conejo");
   Console.WriteLine("7: Salir");
   animalfavorito = Convert.ToInt32(Console.ReadLine());
   switch (animalfavorito)
   {
 case 1:
Console.WriteLine(nombre + "Gato");
break;
case 2:
Console.WriteLine(nombre + "Perro");
break;
case 3:
Console.WriteLine(nombre + "Caballo");
break;
case 4:
Console.WriteLine(nombre + "Lobo");
break;
case 5:
Console.WriteLine(nombre + "Cerdo");
break;
case 6:
Console.WriteLine(nombre + "Conejo");
break;
case 7:
Console.WriteLine(nombre + "Salir");
break;
}
}while(animalfavorito!= 7);



