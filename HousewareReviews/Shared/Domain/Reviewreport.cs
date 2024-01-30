using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace HousewareReviews.Shared.Domain
{
	public class Reviewreport
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Report type must be selected.")]
		public string? Category { get; set; }
        [StringLength(300, ErrorMessage = "Description must not exceed {1} characters.")]
        public string? Description { get; set; }
		public string? Outcome { get; set; }
		public int? ConsumerId { get; set; }
		public virtual Consumer? Consumer { get; set; }
		public int? ReviewId { get; set; }
		public virtual Review? Review { get; set; }
		public int? StaffId { get; set; }
		public virtual Staff? Staff { get; set; }
	}
}
