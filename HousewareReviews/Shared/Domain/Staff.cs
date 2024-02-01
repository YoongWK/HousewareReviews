using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousewareReviews.Shared.Domain
{
    public class Staff
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        [Required(ErrorMessage = "First Name is required.")]
        [DataType(DataType.Text)]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        [DataType(DataType.Text)]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "NRIC is required.")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[STFGstfg]\d{7}[A-Za-z]", ErrorMessage = "NRIC is not valid.")]
        public string? NRIC { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Email is not valid.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Contact Number is required.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not valid.")]
        public string? ContactNumber { get; set; }
        [DataType(DataType.ImageUrl)]
        public string? ProfileImgUri { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password must be {2} to {1} characters long.", MinimumLength = 6)]
        public string? Password { get; set; }
    }
}
