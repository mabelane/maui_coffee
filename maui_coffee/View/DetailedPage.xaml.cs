
using maui_coffee.ViewModel;

namespace maui_coffee.View;

public partial class DetailedPage : ContentPage
{

    public DetailedPage(DetailsViewModel viewModel)
    {
        InitializeComponent();
        
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}
