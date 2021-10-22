using System;
using System.Collections.Generic;
using System.Linq;
using BasicWebShop.Models;
using BasicWebShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BasicWebShop.Controllers
{
    [Route( "")]
    public class HomeController : Controller
    {
        private static List<Item> items;
        private static int Id = 0;
        
        static HomeController()
        {
            items = new List<Item>();
            
            items.Add(new Item()
            {
                Name = "Retriever",
                Description = "Cute long-haired dog",
                Price = 6000.89d,
                Quantity = 3,
                ID = Id++
            });
            
            items.Add(new Item()
            {
                Name = "French Bulldog",
                Description = "Snoring dog",
                Price = 4040.25d,
                Quantity = 4,
                ID = Id++
            });
            items.Add(new Item()
            {
                Name = "Corgi",
                Description = "Best dog in the world",
                Price = 7890.89d,
                Quantity = 0,
                ID = Id++
            });
            items.Add(new Item()
            {
                Name = "Australian Shepherd",
                Description = "Cowboys's herding dog",
                Price = 4509.89d,
                Quantity = 7,
                ID = Id++
            });
            items.Add(new Item()
            {
                Name = "Beagle",
                Description = "Adorable dog",
                Price = 2560.10d,
                Quantity = 5,
                ID = Id++
            });
        }
        
        [HttpGet("home")]
        public IActionResult Index()
        {
            return View(new ShopItems(){allItems = items});
        }
        
        [HttpGet("only-available")]
        public IActionResult DisplayAvailableItems()
        {
            var result = items.Where(p => p.Quantity > 0).ToList();
            return View("Index", new ShopItems()
                {
                    allItems = result
                }
            );
        }
        
        [HttpGet("cheapest-first")]
        public IActionResult DisplayCheapestFirst()
        {
            var result = items.OrderBy(p => p.Price).ToList();
            return View("Index", new ShopItems()
                {
                    allItems = result
                }
            );
        }
        
        [HttpGet("contains-corgi")]
        public IActionResult DisplayCorgi()
        {
            var result = items.Where(p => p.Name == "Corgi").ToList();
            return View("Index", new ShopItems()
                {
                    allItems = result
                }
            );
        }
        
        [HttpGet("average-stock")]
        public IActionResult DisplayAverageStock()
        {
            var result = items.Average(p => p.Quantity).ToString();
            return View("Average", result);
        }
        
        [HttpGet("most-expensive-available")]
        public IActionResult DisplayMostExpensive()
        {
            var result = items.Where(p => p.Quantity != 0).OrderByDescending(p => p.Price).Take(1).ToList();
            return View("Index", new ShopItems()
                {
                    allItems = result
                }
            );
        }
    }
}