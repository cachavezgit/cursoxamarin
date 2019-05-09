using System;
namespace HelloXamarin.Models
{
    public class Aritmetica
    {
        private string _numero1 = string.Empty;
        public string Numero1
        {
            get
            {
                return _numero1;
            }
            set
            {
                _numero1 = value;
            }
        }

        private string _numero2 = string.Empty;
        public string Numero2
        {
            get
            {
                return _numero2;
            }
            set
            {
                _numero2 = value;
            }
        }

        public Aritmetica()
        {
        }
    }
}
