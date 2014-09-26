using System;

namespace App4NumeroSumaPromedio
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double numero1, numero2, numero3, numero4, suma, promedio;
			Console.WriteLine ("Suma Y Promedio De Cuatro Numeros");
			Console.WriteLine ("Ingrese Primer Numero");
			numero1 = double.Parse (Console.ReadLine ());
			Console.WriteLine ("Ingrese Segundo Numero");
			numero2 = double.Parse (Console.ReadLine ());
			Console.WriteLine ("Ingrese Tercer Numero");
			numero3 = double.Parse (Console.ReadLine ());
			Console.WriteLine ("Ingrese Cuarto Numero");
			numero4 = double.Parse (Console.ReadLine ());
			suma = numero1 + numero2 + numero3 + numero4;
			promedio = suma / 4;
			Console.WriteLine ("La Suma De Los 4 Numeros Es: " + suma);
			Console.WriteLine ("El Promedio De Los 4 Numeros Es: " + promedio);
			Console.ReadKey();
		}
	}
}
