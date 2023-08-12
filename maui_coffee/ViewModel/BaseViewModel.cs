using System;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace maui_coffee.ViewModel
{
	public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;
        [ObservableProperty]
        string title;

        public bool IsNotBusy => !IsBusy;
        public BaseViewModel()
		{
		}

        
    }
}

