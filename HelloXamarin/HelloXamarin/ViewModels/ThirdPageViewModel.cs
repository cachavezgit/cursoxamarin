using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HelloXamarin.ViewModels
{
    public class ThirdPageViewModel
    {
        public ICommand BtnCommandMultiplicar { get; set; }

        public ThirdPageViewModel()
        {
            BtnCommandMultiplicar = new Command(async () => await MultiplicarNumeros());
        }

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

        public async Task MultiplicarNumeros()
        {
            int num1 = 0;
            int num2 = 0;
            int.TryParse(Numero1, out num1);
            int.TryParse(Numero2, out num2);
            int resultado = 0;
            if (num1 > 0 && num2 > 0)
            {
                resultado = num1 * num2;
            }
            await Application.Current.MainPage.DisplayAlert("Resultado", $"La multiplicacion de {num1} y {num2} es igual a {resultado}", "Ok");
        }
    }
}
