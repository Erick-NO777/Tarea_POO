using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Tarea
{
    // Clase derivada Revista que extiende Publicacion
    public class Revista : Publicacion
    {
        // Propiedad para almacenar el número de volumen de la revista
        public int NumeroVolumen { get; set; }

        // ID de la categoría de la revista, alineado con la tabla Categorias
        public int CategoriaID { get; set; }

        // Constructor de la clase Revista
        public Revista(string titulo, string autor, string isbn, int añoPublicacion, int numeroVolumen, int categoriaID)
            : base(titulo, autor, isbn, añoPublicacion)
        {
            NumeroVolumen = numeroVolumen;
            CategoriaID = categoriaID; // Asigna la categoría de la revista
        }

        // Método sobrescrito para mostrar información específica de una revista
        public override void MostrarInformacion()
        {
            // Llama al método base para mostrar información común
            base.MostrarInformacion();

            // Muestra detalles específicos de la revista
            Console.WriteLine($"Número de volumen: {NumeroVolumen}, Categoría ID: {CategoriaID}");
        }
    }
}
