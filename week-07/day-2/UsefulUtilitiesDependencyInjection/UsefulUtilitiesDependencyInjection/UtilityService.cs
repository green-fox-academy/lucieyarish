using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace UsefulUtilitiesDependencyInjection.Models
{
    public class UtilityService
    {
        private readonly List<string> colors;
        private readonly Random random;
        private string Email { get; set; }

        public UtilityService()
        {
            colors = new List<string>
            {
                "red",
                "blue",
                "lime",
                "orange",
                "magenta"
            };

            random = new Random();
        }

        public string RandomColor()
        {
            return colors[random.Next(colors.Count)];
        }

        public void ValidateEmail(string email)
        {
            try
            {
                if ((!email.Contains('@') || !email.Contains('.')))
                {
                    Email = email;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Please enter a valid email address.");
            }
        }
    }
}