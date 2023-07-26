using maui_coffee.Model;
using maui_coffee.ViewModel;

namespace maui_coffee.View;

public partial class Home : ContentPage
{
	public Home(CoffeeViewModel coffeeViewModel)
	{
        InitializeComponent();
        BindingContext = coffeeViewModel;
    }



}
