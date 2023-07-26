using CommunityToolkit.Mvvm.Input;
using maui_coffee.Model;
using maui_coffee.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;


namespace maui_coffee.ViewModel
{
    public partial class CoffeeViewModel
    {

        CoffeeService coffeeService;

        public ObservableCollection<Coffee> Coffees { get; } = new();

        public CoffeeViewModel(CoffeeService coffeeService) 
        {
            this.coffeeService = coffeeService;
        }

        [RelayCommand]
       async Task GetCoffeeAsync()
        {
            try
            {
                var coffees = await coffeeService.GetCoffees();

                if (coffees != null)

                    foreach (var coffee in coffees)
                    {
                        Coffees.Add(coffee);
                    }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
        }
    }
}
