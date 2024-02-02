using System.ComponentModel.DataAnnotations;

namespace HousewareReviews.Shared.Domain
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [DataType(DataType.Text)]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Image is required.")]
        [DataType (DataType.ImageUrl)]
        public string? ImgUri { get; set; }
    }
}
