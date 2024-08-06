using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Tarea
{
    // Clase base Publicacion representa una publicación genérica en la biblioteca
    public abstract class Publicacion
    {
        // Propiedades comunes a todas las publicaciones
        public string Titulo { get; set; } // Título de la publicación
        public string Autor { get; set; }  // Autor de la publicación
        public string ISBN { get; set; }   // ISBN único de la publicación
        public int AñoPublicacion { get; set; } // Año de publicación

        // Constructor para inicializar las propiedades comunes
        public Publicacion(string titulo, string autor, string isbn, int añoPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            AñoPublicacion = añoPublicacion;
        }

        // Método virtual para mostrar información de la publicación
        // Las clases derivadas pueden sobrescribir este método para añadir detalles específicos
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Año: {AñoPublicacion}");
        }
    }
}
