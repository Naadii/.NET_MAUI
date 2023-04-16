using RMA_MoneyAssistant.Helpers;
namespace RMA_MoneyAssistant.Pages;

public partial class LoginPage : ContentPage
{
    public User _user;
    public LoginPage(User? user)
	{
		InitializeComponent();
        _user = user;
    }

	private async void CreateAccount_Tapped(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new SignUpPage());
	}

    private void LoginClicked(object sender, EventArgs e)
    {
        if (_user == null)
        {
            DisplayAlert("Warning", "No registered users", "OK");
        }
        else if (UsernameEntry.Text != _user.UserName)
        {
            DisplayAlert("Warning", "Username does not exist!", "OK");
        }
        else if (PassEntry.Text != _user.Password)
        {
            DisplayAlert("Warning", "Incorrect password!", "OK");
        }
        else
        {
            Navigation.PushModalAsync(new ProfilePage());
        }
    }

    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}