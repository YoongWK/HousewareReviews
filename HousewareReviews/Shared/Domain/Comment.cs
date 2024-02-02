using System.ComponentModel.DataAnnotations;

namespace HousewareReviews.Shared.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Comment required")]
        [DataType(DataType.MultilineText)]
        [StringLength(300, ErrorMessage = "Description must not exceed {1} characters.")]
        public string? Description {  get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateUpdated { get; set; }
		public int? UsefulCnt { get; set; }
		public int ReviewId { get; set; }
        public virtual Review? Review { get; set; }
        public int? ConsumerId { get; set; }
        public virtual Consumer? Consumer { get; set; }
    }
}
