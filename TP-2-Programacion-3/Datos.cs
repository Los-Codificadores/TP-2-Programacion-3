using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_2_Programacion_3
{
    public static class Datos
    {
        static private List<Usuario> _usuarios = new List<Usuario>();

        public static void AgregarUsuario(string nombre, string contraseña)
        {
            _usuarios.Add(new Usuario(nombre, contraseña));
        }

        public static List<Usuario> GetUsuarios()
        {
            return _usuarios;
        }

        public static void CargarDatosDePrueba()
        {
            if (_usuarios.Count == 0)
            {
                _usuarios.Add(new Usuario("claudio", "casas"));
            }
        }
    }
}