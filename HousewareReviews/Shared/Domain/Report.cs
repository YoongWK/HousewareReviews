using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousewareReviews.Shared.Domain
{
    public class Report
    {
        public int Id { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public string? Outcome {  get; set; }
        public int? ReviewId { get; set; }
        public virtual Review? Review { get; set; }
        public int? ConsumerId { get; set; }
        public virtual Consumer? Consumer { get; set; }
        public int? CommentId { get; set; }
        public virtual Comment? Comment { get; set; }
        public int? StaffId { get; set; }
        public virtual Staff? Staff { get; set; }

    }
}
