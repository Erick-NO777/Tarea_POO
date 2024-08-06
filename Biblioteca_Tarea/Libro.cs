using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Tarea
{
    // Interfaz IPrestable define métodos para gestionar préstamos de libros
    public interface IPrestable
    {
        void Prestar();  // Método para prestar un libro
        void Devolver(); // Método para devolver un libro
    }

    // Clase derivada Libro hereda de Publicacion e implementa IPrestable
    public class Libro : Publicacion, IPrestable
    {
        // Propiedad para almacenar el número de páginas del libro
        public int NumeroPaginas { get; set; }

        // Propiedad que indica si el libro está prestado
        public bool Prestado { get; private set; }

        // ID de la categoría del libro, alineado con la tabla Categorias
        public int CategoriaID { get; set; }

        // Constructor de la clase Libro
        public Libro(string titulo, string autor, string isbn, int añoPublicacion, int numeroPaginas, int categoriaID)
            : base(titulo, autor, isbn, añoPublicacion)
        {
            NumeroPaginas = numeroPaginas;
            Prestado = false;  // Inicialmente, el libro no está prestado
            CategoriaID = categoriaID; // Asigna la categoría del libro
        }

        // Método sobrescrito para mostrar información específica de un libro
        public override void MostrarInformacion()
        {
            // Llama al método base para mostrar información común
            base.MostrarInformacion();

            // Muestra detalles específicos del libro
            Console.WriteLine($"Número de páginas: {NumeroPaginas}, Prestado: {Prestado}, Categoría ID: {CategoriaID}");
        }

        // Implementación del método Prestar de la interfaz IPrestable
        public void Prestar()
        {
            if (!Prestado)
            {
                Prestado = true;  // Cambia el estado a prestado
                Console.WriteLine($"{Titulo} ha sido prestado.");  // Mensaje de confirmación
            }
            else
            {
                Console.WriteLine($"{Titulo} ya está prestado.");  // Mensaje si el libro ya está prestado
            }
        }

        // Implementación del método Devolver de la interfaz IPrestable
        public void Devolver()
        {
            if (Prestado)
            {
                Prestado = false;  // Cambia el estado a no prestado
                Console.WriteLine($"{Titulo} ha sido devuelto.");  // Mensaje de confirmación
            }
            else
            {
                Console.WriteLine($"{Titulo} no estaba prestado.");  // Mensaje si el libro no estaba prestado
            }
        }
    }
}
