using System.ComponentModel.DataAnnotations;

namespace HousewareReviews.Shared.Domain
{
    public class Review
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Rating is required.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int? Rating { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        [DataType(DataType.MultilineText)]
        [StringLength(300, ErrorMessage = "Description must not exceed {1} characters.")]
        public string? Description { get; set; }
        [DataType(DataType.MultilineText)]
        [StringLength(300, ErrorMessage = "Reply must not exceed {1} characters.")]
        public string? Reply { get; set; }
        public int? UsefulCnt { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateUpdated { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? DateReplied { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public int? ConsumerId { get; set; }
        public virtual Consumer? Consumer { get; set; }
    }
}
