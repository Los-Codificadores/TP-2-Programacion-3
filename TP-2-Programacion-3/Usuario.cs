using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_2_Programacion_3
{
    public class Usuario
    {
        private string _nombre;
        private string _contraseña;

        public Usuario(string nombre, string contraseña)
        {
            _nombre = nombre;
            _contraseña = contraseña;
        }

        public string getNombre()
        {
            return _nombre;
        }

        public string getContraseña ()
        {
            return _contraseña;
        }
    }
}