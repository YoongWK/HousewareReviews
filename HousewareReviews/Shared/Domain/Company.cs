using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousewareReviews.Shared.Domain
{
    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? UEN {  get; set; }
        public string? Email { get; set; }
        public string? ContactNumber { get; set; }
        public string? Description { get; set; }
        public string? LogoUri { get; set; }
        public string? WebsiteUrl { get; set;}

    }
}
