using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousewareReviews.Shared.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public string? ImgUri {  get; set; }
        public int? CompanyId { get; set; }
        public virtual Company? Company { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set;}
    }
}
