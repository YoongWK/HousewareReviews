using System.ComponentModel.DataAnnotations;

namespace HousewareReviews.Shared.Domain
{
	public class Reviewreport
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Category is required.")]
        [DataType(DataType.Text)]
        public string? Category { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        [DataType(DataType.MultilineText)]
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
