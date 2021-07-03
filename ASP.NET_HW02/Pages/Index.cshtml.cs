using ASP.NET_HW02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_HW02.Pages
{
    public class IndexModel : PageModel
    {
        public List<Item> items = new List<Item> {
            new Item{Name = "Samsung Galaxy A51", Price = 7599 , Manufacturer = "Samsung"},
            new Item{Name = "Apple iPhone 11", Price = 21499 , Manufacturer = "Apple"},
            new Item{Name = "Xiaomi Redmi Note 9 Pro", Price = 6999 , Manufacturer = "Xiaomi"},
            new Item{Name = "Apple iPhone 12 Pro Max", Price = 39499 , Manufacturer = "Apple"},
            new Item{Name = "Samsung Galaxy M12", Price = 4599 , Manufacturer = "Samsung"},
            new Item{Name = "Xiaomi Redmi Note 10 5G", Price = 5799 , Manufacturer = "Xiaomi"},
            new Item{Name = "Samsung Galaxy A32", Price = 6599 , Manufacturer = "Samsung"},
            new Item{Name = "Apple iPhone SE", Price = 14599 , Manufacturer = "Apple"},
            new Item{Name = "Xiaomi Mi 11", Price = 20699 , Manufacturer = "Xiaomi"},
        };
        public List<Item> DisplayedItems { get; set; }

       

        public void OnGet()
        {
            DisplayedItems = items;
        }
        public void OnPostLessThan(int price)
        {
            DisplayedItems = items.Where(p => p.Price < price).ToList();
        }
        public void OnPostGreaterThan(int price)
        {
            DisplayedItems = items.Where(p => p.Price > price).ToList();
        }
        public void OnPostSearch(string str)
        {
            DisplayedItems = items.Where(p => p.Manufacturer.ToLower().Contains(str.ToLower()) || p.Name.ToLower().Contains(str.ToLower())).ToList();
        }
        public void OnPostDisplayDetales(string name)
        {
            DisplayedItems = items.Where(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
        }
    }
}

