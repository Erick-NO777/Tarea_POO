using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Tarea
{
    class Program
    {
        // Listas para almacenar los objetos en memoria
        static List<Libro> libros = new List<Libro>(); // Lista de libros
        static List<Usuario> usuarios = new List<Usuario>(); // Lista de usuarios
        static List<Prestamo> prestamos = new List<Prestamo>(); // Lista de préstamos

        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                // Mostrar el menú principal
                Console.WriteLine("\nBienvenido al Sistema de Gestión de Biblioteca");
                Console.WriteLine("1. Agregar Libro");
                Console.WriteLine("2. Mostrar Libros");
                Console.WriteLine("3. Agregar Usuario");
                Console.WriteLine("4. Mostrar Usuarios");
                Console.WriteLine("5. Prestar Libro");
                Console.WriteLine("6. Mostrar Préstamos");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");

                // Capturar la opción seleccionada por el usuario
                switch (Console.ReadLine())
                {
                    case "1":
                        AgregarLibro();
                        break;
                    case "2":
                        MostrarLibros();
                        break;
                    case "3":
                        AgregarUsuario();
                        break;
                    case "4":
                        MostrarUsuarios();
                        break;
                    case "5":
                        PrestarLibro();
                        break;
                    case "6":
                        MostrarPrestamos();
                        break;
                    case "7":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
                        break;
                }
            }
        }

        // Método para agregar un libro a la biblioteca
        static void AgregarLibro()
        {
            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();

            Console.Write("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();

            Console.Write("Ingrese el ISBN del libro: ");
            string isbn = Console.ReadLine();

            Console.Write("Ingrese el año de publicación: ");
            int añoPublicacion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de páginas: ");
            int numeroPaginas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el ID de la categoría: ");
            int categoriaID = int.Parse(Console.ReadLine());

            // Crear un nuevo objeto Libro y agregarlo a la lista
            Libro nuevoLibro = new Libro(titulo, autor, isbn, añoPublicacion, numeroPaginas, categoriaID);
            libros.Add(nuevoLibro);

            Console.WriteLine($"Libro '{titulo}' agregado exitosamente.");
        }

        // Método para mostrar todos los libros en la biblioteca
        static void MostrarLibros()
        {
            Console.WriteLine("\nLista de Libros:");
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros en la biblioteca.");
            }
            else
            {
                foreach (var libro in libros)
                {
                    libro.MostrarInformacion();
                }
            }
        }

        // Método para agregar un usuario a la biblioteca
        static void AgregarUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido del usuario: ");
            string apellido = Console.ReadLine();

            Console.Write("Ingrese el número de socio: ");
            string numeroSocio = Console.ReadLine();

            // Crear un nuevo objeto Usuario y agregarlo a la lista
            Usuario nuevoUsuario = new Usuario(usuarios.Count + 1, nombre, apellido, numeroSocio);
            usuarios.Add(nuevoUsuario);

            Console.WriteLine($"Usuario '{nombre} {apellido}' agregado exitosamente.");
        }

        // Método para mostrar todos los usuarios de la biblioteca
        static void MostrarUsuarios()
        {
            Console.WriteLine("\nLista de Usuarios:");
            if (usuarios.Count == 0)
            {
                Console.WriteLine("No hay usuarios registrados en la biblioteca.");
            }
            else
            {
                foreach (var usuario in usuarios)
                {
                    usuario.MostrarInformacion();
                }
            }
        }

        // Método para prestar un libro a un usuario
        static void PrestarLibro()
        {
            Console.Write("Ingrese el ISBN del libro a prestar: ");
            string isbn = Console.ReadLine();

            // Buscar el libro por ISBN
            Libro libro = libros.Find(l => l.ISBN == isbn);
            if (libro == null || libro.Prestado)
            {
                Console.WriteLine("El libro no está disponible para préstamo.");
                return;
            }

            Console.Write("Ingrese el número de socio del usuario: ");
            string numeroSocio = Console.ReadLine();

            // Buscar el usuario por número de socio
            Usuario usuario = usuarios.Find(u => u.NumeroSocio == numeroSocio);
            if (usuario == null)
            {
                Console.WriteLine("Usuario no encontrado.");
                return;
            }

            Console.Write("Ingrese la fecha de devolución (yyyy-mm-dd): ");
            DateTime fechaDevolucion;
            if (!DateTime.TryParse(Console.ReadLine(), out fechaDevolucion))
            {
                Console.WriteLine("Fecha de devolución no válida.");
                return;
            }

            // Realizar el préstamo del libro
            libro.Prestar();
            Prestamo nuevoPrestamo = new Prestamo(prestamos.Count + 1, libro, usuario, DateTime.Now, fechaDevolucion);
            prestamos.Add(nuevoPrestamo);

            Console.WriteLine($"Préstamo realizado exitosamente. Devolución esperada: {fechaDevolucion.ToShortDateString()}");
        }

        // Método para mostrar todos los préstamos
        static void MostrarPrestamos()
        {
            Console.WriteLine("\nLista de Préstamos:");
            if (prestamos.Count == 0)
            {
                Console.WriteLine("No hay préstamos registrados.");
            }
            else
            {
                foreach (var prestamo in prestamos)
                {
                    prestamo.MostrarInformacion();
                }
            }
        }
    }
}
