namespace Numerical_CalculationApp_Maui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void ToCalculationPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CalculationPage());

    }
}

