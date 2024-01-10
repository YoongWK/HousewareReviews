using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousewareReviews.Shared.Domain
{
    public class Consumer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NRIC { get; set; }
        public string? Email { get; set; }
        public string? ContactNumber { get; set; }
        public string? ProfileImgUri { get; set; }
        public string? Password { get; set; }
    }
}
