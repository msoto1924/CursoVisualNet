using System;

namespace AreaYPerimetroCuadrado
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float lado, area, perimetro;
			Console.WriteLine ("Programa Calcula Area Y Perimetro De Un Cuadrado");
			Console.WriteLine ("Digite Lado");
			lado = float.Parse (Console.ReadLine ());
			area = lado * lado;
			Console.WriteLine ("El Area Del Cuadrado Es: "+area);
			perimetro = 4 * area;
			Console.WriteLine ("El Perimetro Del Cuadrado Es: "+perimetro);
			Console.ReadKey ();
		}
	}
}
