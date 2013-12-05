
using System;
using System.Collections;

namespace Practica3
{
	
	public class Directorio
	{
        public Hashtable tabla = new Hashtable();
		
        public Directorio()
		{
			this.tabla = new Hashtable();
		}
		public void capturar () {
			for (int i=0; i<4; i++){
				Persona persona= new Persona ();
				Console.WriteLine("\nCodigo:");
				persona.codigo =int.Parse(Console.ReadLine());
				
				Console.WriteLine("\nNombre:");
				persona.nombre = Console.ReadLine();
				
				Console.WriteLine("\nTeléfono:");
				persona.telefono = Console.ReadLine();
				
				Console.WriteLine("\nFacebook:");
				persona.facebook = Console.ReadLine();
				this.tabla.Add(persona.codigo,persona);
			}
			 
		}


    
		public void editar () {
            int codigoEditar;
			for (int i=0; i<4; i++){
			Console.WriteLine("\nCodigo que decea editar:");
           codigoEditar = int.Parse(Console.ReadLine());

           Persona persona = (Persona)this.tabla[codigoEditar];

           Console.WriteLine("Editando la llave: " + persona.codigo);
			
                Console.WriteLine("Nombre:");
				persona.nombre= Console.ReadLine();
				Console.WriteLine("Teléfono: ");
				persona.telefono=Console.ReadLine();
				Console.WriteLine("Facebook:");
				persona.facebook=Console.ReadLine();
                this.tabla[codigoEditar] = persona;
                 
                if (!this.tabla.ContainsKey(codigoEditar)){
                	Console.WriteLine("codigoEditar" + persona.codigo + "La llave fue editada");
                }
			}
			
		}

		public void eliminar() {
            int codigoEliminar;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\nCodigo que desea eliminar");
                codigoEliminar = int.Parse(Console.ReadLine());

                if (this.tabla.ContainsKey(codigoEliminar)){
                	this.tabla.Remove(codigoEliminar);
                	Console.WriteLine("\nEliminado");
                }else{
                	Console.WriteLine("codigoEliminar" + codigoEliminar + "No se encuentra la llave");
                }


            }
		}

		public void imprimir () {
            ICollection keys = this.tabla.Keys;

            Console.WriteLine("\tCódigo:\t\tNombre:\t\tTeléfono:\tFacebook:");

            foreach (int key in keys)
            {

                Persona persona = (Persona)this.tabla[key];
                Console.WriteLine("\t" + persona.codigo + "\t\t" + persona.nombre + "\t\t" + persona.telefono + "\t\t" + persona.facebook);
                
            }
		}
			
	}
}

