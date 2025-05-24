namespace MauiAppHotel.Views;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
	}

    private void btn_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}