//Se ingresan tres notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado".
using System;

namespace AppNotasPromedio
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float nota1, nota2, nota3, promedio;
			Console.WriteLine ("Ingrese Las Tres Notas Del ALumno");
			Console.WriteLine ("Ingrese La Primera Nota");
			nota1=float.Parse (Console.ReadLine ());
			Console.WriteLine ("Ingrese La segunda Nota");
			nota2=float.Parse (Console.ReadLine ());
			Console.WriteLine ("Ingrese La Tercera Nota");
			nota3=float.Parse (Console.ReadLine ());
			promedio = (nota1 + nota2 + nota3)/3;
			if (promedio >= 7) {
				Console.WriteLine ("Promocionado");
				Console.ReadKey ();
			}
				else
			{
				Console.WriteLine ("Reprobo");
				Console.ReadKey();
			}
		}
	}
}
