using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

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

        public string ValidateEmail(string email)
        {
            Email = email;
            if ((email.Contains('@') && email.Contains('.')))
            {
                return $"<p style=\"color:green\">{email}</p>";
            }
            return $"<p style=\"color:red\">{email} is not valid</p>";
        }
        
        public string Caesar(string text, int shift)
        {
            if (shift < 0)
            {
                shift = shift + 26;
            }

            string result = "";

            foreach (var character in text)
            {
                var offset = char.IsUpper(character) ? 'A' : 'a';
                result += (char)((character + shift - offset) % 26 + offset);
            }

            return result;
        }
    }
}