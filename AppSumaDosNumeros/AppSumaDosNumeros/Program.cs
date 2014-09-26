using System;

namespace AppSumaDosNumeros
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Declaracion De Variables
			int numero1, numero2, suma;
			string linea;
			Console.WriteLine ("Suma Dos Numeros");
			Console.WriteLine ("Digite Primer Numero");
			linea = Console.ReadLine ();
			numero1 = int.Parse (linea);
			Console.WriteLine ("Digite Segundo Numero");
			linea = Console.ReadLine ();
			numero2 = int.Parse (linea);
			suma = numero1 + numero2;
			Console.WriteLine ("La Suma Es: " + suma);
			Console.ReadKey ();
		}
	}
}
