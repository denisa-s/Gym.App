using Proiect1.ViewModel;

namespace Proiect1.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		this.BindingContext = new LoginViewModel(this.Navigation);
	}
}