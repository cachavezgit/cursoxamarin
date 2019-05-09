using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using HelloXamarin.Models;
using HelloXamarin.Services;
using Xamarin.Forms;

namespace HelloXamarin.ViewModels
{
    public class ThirdPageViewModel
    {
        public ICommand BtnCommandMultiplicar { get; set; }

        private Aritmetica _datos;
        public Aritmetica Datos
        {
            get
            {
                return _datos;
            }
            set
            {
                _datos = value;
            }
        }

        private List<Persona> _personas;
        public List<Persona> Personas
        {
            get
            {
                return _personas;
            }
            set
            {
                _personas = value;
            }
        }

        public ThirdPageViewModel()
        {
            BtnCommandMultiplicar = new Command(async () => await MultiplicarNumeros());
            Datos = new Aritmetica();
            PersonaServices personaService = new PersonaServices();
            Personas = personaService.GetPersonas();
        }

        public async Task MultiplicarNumeros()
        {
            int.TryParse(Datos.Numero1, out int num1);
            int.TryParse(Datos.Numero2, out int num2);
            int resultado = 0;
            if (num1 > 0 && num2 > 0)
            {
                resultado = num1 * num2;
            }
            await Application.Current.MainPage.DisplayAlert("Resultado", $"La multiplicacion de {num1} y {num2} es igual a {resultado}", "Ok");
        }
    }
}
