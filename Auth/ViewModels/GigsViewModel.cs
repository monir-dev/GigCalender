using Auth.Models;
using System.Collections.Generic;

namespace Auth.ViewModels
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcommingGigs { get; set; }
        public bool ShowActions { get; set; }
        public string Heading { get; set; }
    }
}