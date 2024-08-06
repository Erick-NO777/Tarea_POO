using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Tarea
{
    // Clase que representa a un usuario de la biblioteca
    public class Usuario
    {
        // Propiedades que coinciden con las columnas de la tabla Usuarios
        public int UsuarioID { get; set; } // Identificador único del usuario
        public string Nombre { get; set; } // Nombre del usuario
        public string Apellido { get; set; } // Apellido del usuario
        public string NumeroSocio { get; set; } // Número de socio (único)

        // Constructor de la clase Usuario
        public Usuario(int usuarioID, string nombre, string apellido, string numeroSocio)
        {
            UsuarioID = usuarioID;
            Nombre = nombre;
            Apellido = apellido;
            NumeroSocio = numeroSocio;
        }

        // Método para mostrar información del usuario
        public void MostrarInformacion()
        {
            Console.WriteLine($"Usuario ID: {UsuarioID}, Nombre: {Nombre}, Apellido: {Apellido}, Número de Socio: {NumeroSocio}");
        }
    }
}
