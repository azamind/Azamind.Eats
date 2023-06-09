using Azamind.Eats.Pages;

namespace Azamind.Eats;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new GetStartedPage());
	}



}

