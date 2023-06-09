namespace Azamind.Eats.Pages;

public partial class GetStartedPage : ContentPage
{
	public GetStartedPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

}