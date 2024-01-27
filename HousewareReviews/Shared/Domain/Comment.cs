using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousewareReviews.Shared.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        public string? Description {  get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
		public int? UsefulCnt { get; set; }
		public int ReviewId { get; set; }
        public virtual Review? Review { get; set; }
        public int? ConsumerId { get; set; }
        public virtual Consumer? Consumer { get; set; }
    }
}
