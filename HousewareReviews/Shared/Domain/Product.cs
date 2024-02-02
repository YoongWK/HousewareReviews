using System.ComponentModel.DataAnnotations;

namespace HousewareReviews.Shared.Domain
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [DataType(DataType.Text)]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        [DataType(DataType.MultilineText)]
        [StringLength(300, ErrorMessage = "Description must not exceed {1} characters.")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        [DataType(DataType.Currency)]
        [Range(0.01, 10000.00, ErrorMessage = "Price must range from {1} to {2}.")]
        public double? Price { get; set; }
        [Required(ErrorMessage = "Image is required.")]
        [DataType(DataType.ImageUrl)]
        public string? ImgUri {  get; set; }
        [Required(ErrorMessage = "Company is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Company is required.")]
        public int CompanyId { get; set; }
        public virtual Company? Company { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set;}
    }
}
