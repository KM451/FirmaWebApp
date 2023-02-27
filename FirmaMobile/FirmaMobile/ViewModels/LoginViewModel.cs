using FirmaMobile.Models;
using FirmaMobile.Views;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    public class LoginViewModel : BaseViewModel<Item>
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
