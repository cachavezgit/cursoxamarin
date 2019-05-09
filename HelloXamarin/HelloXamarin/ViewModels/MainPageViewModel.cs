using System;
using System.Threading.Tasks;
using System.Windows.Input;
using HelloXamarin.Views;
using Xamarin.Forms;

namespace HelloXamarin.ViewModels
{
    public class MainPageViewModel //: BaseViewModel
    {
        public ICommand BtnCommand { get; set; }
        public ICommand SaludoCommand { get; set; }
        public ICommand Btn3Command { get; set; }

        public MainPageViewModel()
        {
            BtnCommand = new Command(GoToSecondPage);
            SaludoCommand = new Command(async () => await Saludo());
            Btn3Command = new Command(async () => await GoTo3rdPage());
        }

        public async void GoToSecondPage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(new SecondPage()));
        }

        public async Task Saludo()
        {
            await Application.Current.MainPage.DisplayAlert("Saludo", "Hola Usuario", "Ok");
        }

        public async Task GoTo3rdPage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(new ThirdPage()));
        }
    }
}
