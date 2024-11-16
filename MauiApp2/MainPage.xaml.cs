using Microsoft.Maui.Controls;
namespace MauiApp2;


    public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        DisplayAlert("Message", "Hello World!", "OK");
    }
}
