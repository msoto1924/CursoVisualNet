using System;

namespace AppDosNumeros
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num1, num2, suma, diferencia, producto, division;
			Console.WriteLine ("Programa Mayor De Dos Numeros");
			Console.WriteLine ("Ingrese El Primer Numero");
			num1 = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Ingrese El Segundo Numero");
			num2 = int.Parse (Console.ReadLine ());
			if (num1>num2)
			{
				suma = num1 + num2;
				diferencia = num1 - num2;

		}
	}
}
