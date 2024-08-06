using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Tarea
{
    // Clase que representa un préstamo en la biblioteca
    public class Prestamo
    {
        // Propiedades que coinciden con las columnas de la tabla Prestamos
        public int PrestamoID { get; set; } // Identificador único del préstamo
        public Libro LibroPrestado { get; set; } // Libro que ha sido prestado
        public Usuario UsuarioPrestamo { get; set; } // Usuario que realiza el préstamo
        public DateTime FechaPrestamo { get; set; } // Fecha del préstamo
        public DateTime FechaDevolucion { get; set; } // Fecha esperada de devolución

        // Constructor de la clase Prestamo
        public Prestamo(int prestamoID, Libro libroPrestado, Usuario usuarioPrestamo, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            PrestamoID = prestamoID;
            LibroPrestado = libroPrestado;
            UsuarioPrestamo = usuarioPrestamo;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
        }

        // Método para mostrar información del préstamo
        public void MostrarInformacion()
        {
            Console.WriteLine($"Préstamo ID: {PrestamoID}");
            Console.WriteLine($"Libro: {LibroPrestado.Titulo} ({LibroPrestado.ISBN})");
            Console.WriteLine($"Usuario: {UsuarioPrestamo.Nombre} {UsuarioPrestamo.Apellido} (Nº Socio: {UsuarioPrestamo.NumeroSocio})");
            Console.WriteLine($"Fecha de Préstamo: {FechaPrestamo.ToShortDateString()}, Fecha de Devolución: {FechaDevolucion.ToShortDateString()}");
        }
    }
}
