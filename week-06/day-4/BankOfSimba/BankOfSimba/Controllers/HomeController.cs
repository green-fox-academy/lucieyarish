using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;

namespace BankOfSimba.Controllers
{
    [Route("")] 
    public class HomeController : Controller
    {
        [HttpGet("show")]
        public IActionResult Index()
        {
            var simba = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000.00d,
                AnimalType = "lion"
            };
            return View(simba);
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            string raw = "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";
            return View("Test", raw);
        }

        [HttpGet("multiple-accounts")]
        public IActionResult MultipleAccounts()
        {
            var animalAccounts = new List<BankAccount>();

            animalAccounts.Add(new BankAccount()
            {
                Name = "Simba",
                Balance = 2000.99,
                AnimalType = "Lion",
                IsKing = true,
                IsGood = true

            });
            animalAccounts.Add(new BankAccount()
            {
                Name = "Timon",
                Balance = 2050.68,
                AnimalType = "Meerkat",
                IsGood = true
            });
            animalAccounts.Add(new BankAccount()
            {
                Name = "Pumbaa",
                Balance = 3060.38,
                AnimalType = "Warthog",
                IsGood = true
            });
            animalAccounts.Add(new BankAccount()
            {
                Name = "Nala",
                Balance = 4788.99,
                AnimalType = "Lioness",
                IsGood = true
            });
            animalAccounts.Add(new BankAccount()
            {
                Name = "Scar",
                Balance = 843.12,
                AnimalType = "Lion"
            });
            
            return View(new MultipleAccounts()
            {
                multipleAccounts = animalAccounts
            });
        }

        // [HttpPost("increaseBalance")]
        // public ActionResult IncreaseBalance(int accountID)
        // {
        //     if(ViewModels.MultipleAccounts(accountID))
        // }
    }
}