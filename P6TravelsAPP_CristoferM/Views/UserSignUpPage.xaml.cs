namespace P6TravelsAPP_CristoferM.Views;

public partial class UserSignUpPage : ContentPage
{
	public UserSignUpPage()
	{
		InitializeComponent();
	}

    private async void BtnCancel_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}