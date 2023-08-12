
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using maui_coffee.Model;

namespace maui_coffee.ViewModel
{
	[QueryProperty("Coffee", "Coffee")]
	public partial class DetailsViewModel : BaseViewModel
    {
        public double ScrHeight { get; set; }
        public DetailsViewModel()
		{
            ScrHeight = (DeviceDisplay.Current.MainDisplayInfo.Height) * 0.18;
        }

		[ObservableProperty]
		Coffee coffee;

        [RelayCommand]
        async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..",true);
        }
    }
}

