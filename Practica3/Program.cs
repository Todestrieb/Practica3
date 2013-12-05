using System;
using System.Collections;


namespace Practica3
{
	class Program
	{
		public static void Main(string[] args)
		{
		 Directorio directorio = new Directorio ();
			directorio.capturar();
            Console.Clear();
            directorio.imprimir();
			directorio.editar();
            directorio.imprimir();
			directorio.eliminar();
			directorio.imprimir();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}	
