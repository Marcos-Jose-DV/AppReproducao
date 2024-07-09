using AppTeste.ViewModels;

namespace AppTeste.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

		BindingContext = new HomeViewModel();
	}
}