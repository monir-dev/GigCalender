using Auth.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Auth.ViewModels
{
    public class GigFormViewModel
    {
        [Required]
        public string Vanue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [Validtime]
        public string Time { get; set; }

        [Required]
        public byte Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public DateTime getDateTime()
        {
            return DateTime.Parse($"{Date} {Time}");
        }
    }
}