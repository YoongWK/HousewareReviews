using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousewareReviews.Shared.Domain
{
    public class Review
    {
        public int Id { get; set; }
        public int? Rating { get; set; }
        public string? Description { get; set; }
        public string? Reply { get; set; }
        // public int? UsefulCnt { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime? DateReplied { get; set; }
        public int? ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public int? ConsumerId { get; set; }
        public virtual Consumer? Consumer { get; set; }
        public virtual List<Consumer>? ConsumersFoundUseful { get; set; }
    }
}
