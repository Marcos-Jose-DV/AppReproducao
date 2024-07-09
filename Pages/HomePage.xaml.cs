using AppTeste.ViewModels;

namespace AppTeste.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

		BindingContext = new HomeViewModel();
	}
    private void OnPointerEntered(object sender, PointerEventArgs e)
    {
        var image = sender as Image;
        if (image == null)
            return;

        AnimationScaleTo(image, 1.2);
    }

    private void OnPointerExited(object sender, PointerEventArgs e)
    {
        var image = sender as Image;
        if (image == null)
            return;

        AnimationScaleTo(image);
    }
    private async void AnimationScaleTo(Image image, double cale = 1)
    {
        uint duration = 550;
        await image.ScaleTo(cale, duration, Easing.CubicInOut);
    }
}