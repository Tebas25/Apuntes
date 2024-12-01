namespace Apuntes.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void Boton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.About about)
        {
            await Launcher.Default.OpenAsync("https://aka.ms/maui");
        }
    }
}