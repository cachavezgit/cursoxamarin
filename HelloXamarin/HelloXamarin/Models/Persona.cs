using System;
namespace HelloXamarin.Models
{
    public class Persona
    {
        private string _nombre = string.Empty;
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        private string _apellidos = string.Empty;
        public string Apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                _apellidos = value;
            }
        }

        public Persona(string n, string a)
        {
            this.Nombre = n;
            this.Apellidos = a;
        }

    }
}
