﻿using System;
using System.Collections.Generic;
using maui_coffee.Model;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace maui_coffee.Services
{
    public partial class CoffeeService
    {
        HttpClient HttpClient;

        public CoffeeService()
        {
            HttpClient = new HttpClient();
        }
        List<Coffee> coffeeList = new();


        public async Task<List<Coffee>> GetCoffees()
        {
            if (coffeeList?.Count > 0)
                return coffeeList;
            /* var url = "https://raw.githubusercontent.com/mabelane/maui_coffee/main/maui_coffee/Resources/Raw/coffeedata.json";

            var response = await HttpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                coffeeList = await response.Content.ReadFromJsonAsync<List<Coffee>>();
            } */

            using var stream = await FileSystem.OpenAppPackageFileAsync("coffeedata.json");
            using var reader = new StreamReader(stream);
            var content = await reader.ReadToEndAsync();
            coffeeList = JsonSerializer.Deserialize<List<Coffee>>(content); 
            return coffeeList;
        }
    }
}
