using HomeKit;
using RMA_MoneyAssistant.Helpers;

namespace RMA_MoneyAssistant.Pages;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}
    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    private async void Login_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage(null));
    }

    private void NextClicked(object sender, EventArgs e)
    {
        if ((UsernameEntry.Text != null) && (PassEntry.Text != null) && (PassConfirmEntry.Text != null))
        {
            if (PassEntry.Text != PassConfirmEntry.Text)
            {
                DisplayAlert("Warning", "Incorrect password!", "OK");
            }
            else
            {
                User _user = new User();

                _user.UserName = UsernameEntry.Text;
                _user.Password = PassEntry.Text;

                Navigation.PushModalAsync(new LoginPage(_user));
            }
        }
        else
        {
            DisplayAlert("Warning", "Please enter all information!", "OK");
        }
    }
}