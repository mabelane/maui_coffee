using System;
using System.Collections.Generic;
using maui_coffee.Model;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace maui_coffee.Services
{
    public partial class CoffeeService
    {
        List<Coffee> coffeeList = new();
        public async Task<List<Coffee>> GetCoffees()
        {
            if (coffeeList?.Count > 0)
                return coffeeList;

            using var stream = await FileSystem.OpenAppPackageFileAsync("coffeedata.json");
            using var reader = new StreamReader(stream);
            var content = await reader.ReadToEndAsync();
            coffeeList = JsonSerializer.Deserialize<List<Coffee>>(content);
            return coffeeList;
        }
    }
}
