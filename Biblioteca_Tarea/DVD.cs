using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Tarea
{
    // Clase derivada DVD que extiende Publicacion
    public class DVD : Publicacion
    {
        // Propiedad para almacenar la duración del DVD
        public TimeSpan Duracion { get; set; }

        // ID de la categoría del DVD, alineado con la tabla Categorias
        public int CategoriaID { get; set; }

        // Constructor de la clase DVD
        public DVD(string titulo, string autor, string isbn, int añoPublicacion, TimeSpan duracion, int categoriaID)
            : base(titulo, autor, isbn, añoPublicacion)
        {
            Duracion = duracion; // Asigna la duración del DVD
            CategoriaID = categoriaID; // Asigna la categoría del DVD
        }

        // Método sobrescrito para mostrar información específica de un DVD
        public override void MostrarInformacion()
        {
            // Llama al método base para mostrar información común
            base.MostrarInformacion();

            // Muestra detalles específicos del DVD
            Console.WriteLine($"Duración: {Duracion}, Categoría ID: {CategoriaID}");
        }
    }
}
