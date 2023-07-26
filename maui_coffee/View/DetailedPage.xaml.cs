
namespace maui_coffee.View;

public partial class DetailedPage : ContentPage
{
    public double ScrHeight { get; set; }

    public DetailedPage()
    {
        InitializeComponent();
        ScrHeight = (DeviceDisplay.Current.MainDisplayInfo.Height) * 0.18;
        BindingContext = this;
    }
}
