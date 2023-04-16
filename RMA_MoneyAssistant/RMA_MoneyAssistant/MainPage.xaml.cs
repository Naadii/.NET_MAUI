using RMA_MoneyAssistant.Pages;

namespace RMA_MoneyAssistant;

public partial class MainPage : ContentPage
{
	//int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new LoginPage(null));
    }
    private async void OnSignupClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new SignUpPage());
    }

}

