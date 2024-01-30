using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousewareReviews.Shared.Domain
{
    public class Company
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "UEN is required.")]
        [RegularExpression(@"^(\d{9}[A-Za-z]|\d{8}[A-Za-z]|T\d{2}[A-Za-z]\d[A-Za-z]\d{4}[A-Za-z])$", ErrorMessage = "UEN is not valid.")]
        public string? UEN {  get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Email Address is not a valid email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Contact Number is required.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not valid.")]
        public string? ContactNumber { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        [StringLength(300, ErrorMessage = "Description must not exceed {1} characters.")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Logo is required.")]
        public string? LogoUri { get; set; }
        [Required(ErrorMessage = "Website Url is required.")]
        [RegularExpression(@"(http(s)?://)?([\w-]+\.)+[\w-]+(/[\w- ;,./?%&=]*)?", ErrorMessage = "Website Url is not valid.")]
        public string? WebsiteUrl { get; set;}
    }
}
