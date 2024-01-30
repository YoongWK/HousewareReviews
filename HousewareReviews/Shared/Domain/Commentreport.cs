using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousewareReviews.Shared.Domain
{
    public class Commentreport
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Report type must be selected.")]
        public string? Category { get; set; }
        [StringLength(300, ErrorMessage = "Description must not exceed {1} characters.")]
        public string? Description { get; set; }
        public string? Outcome {  get; set; }
        public int? ConsumerId { get; set; }
        public virtual Consumer? Consumer { get; set; }
        public int? CommentId { get; set; }
        public virtual Comment? Comment { get; set; }
        public int? StaffId { get; set; }
        public virtual Staff? Staff { get; set; }
    }
}
