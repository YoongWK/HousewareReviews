// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HousewareReviews.Server.Data;
using HousewareReviews.Server.Models;
using HousewareReviews.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HousewareReviews.Server.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly ApplicationDbContext _context;

		public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
			ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
			_context = context;
		}

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        //public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
			/// <summary>
			///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
			///     directly from your code. This API may change or be removed in future releases.
			/// </summary>
			[Display(Name = "Profile Image")]
			public string ProfileImgUri { get; set; }

			[Required(ErrorMessage = "First Name is required.")]
			[Display(Name = "First Name")]
			public string FirstName { get; set; }

			[Required(ErrorMessage = "Last Name is required.")]
			[Display(Name = "Last Name")]
			public string LastName { get; set; }

			[Required(ErrorMessage = "NRIC is required.")]
			[RegularExpression(@"^[STFGstfg]\d{7}[A-Za-z]", ErrorMessage = "NRIC is not valid.")]
			[Display(Name = "NRIC")]
			public string NRIC { get; set; }

			[Required(ErrorMessage = "Email is required.")]
			[EmailAddress(ErrorMessage = "Email is not valid.")]
			[Display(Name = "Email")]
			public string Email { get; set; }

			[Required(ErrorMessage = "Contact Number is required.")]
			[DataType(DataType.PhoneNumber)]
			[RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not valid.")]
			[Display(Name = "Contact Number")]
			public string ContactNumber { get; set; }
		}

		private void Load(ApplicationUser user, Staff staff, Consumer consumer, string role)
		{
			var profileImgUri = "";
			var firstName = "";
			var lastName = "";
			var nric = "";
			var email = "";
			var contactNumber = "";
			if (role == "Staff")
			{
				profileImgUri = staff.ProfileImgUri;
				firstName = staff.FirstName;
				lastName = staff.LastName;
				nric = staff.NRIC;
				email = staff.Email;
				contactNumber = staff.ContactNumber;
			}
			else if (role == "Consumer")
			{
				profileImgUri = consumer.ProfileImgUri;
				firstName = consumer.FirstName;
				lastName = consumer.LastName;
				nric = consumer.NRIC;
				email = consumer.Email;
				contactNumber = consumer.ContactNumber;
			}
			Input = new InputModel
			{
				ProfileImgUri = profileImgUri,
				FirstName = firstName,
				LastName = lastName,
				NRIC = nric,
				Email = email,
				ContactNumber = contactNumber,
			};
		}

		public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (User.IsInRole("Staff"))
            {
				var staff = _context.Staffs.FirstOrDefault(u => u.UserId == user.Id);
                if (staff == null)
                {
                    return NotFound($"Unable to load staff with ID '{user.Id}'");
                }
                Load(user, staff, null, "Staff");
			}
            else if (User.IsInRole("Consumer"))
            {
                var consumer = _context.Consumers.FirstOrDefault(u => u.UserId == user.Id);
                if (consumer == null)
                {
                    return NotFound($"Unable to load consumer with ID '{user.Id}'");
                }
				Load(user, null, consumer, "Consumer");
			}
            else
            {
				return NotFound($"Unable to find role of user with ID '{user.Id}'.");
			}
			return Page();
		}

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);

			if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

			if (User.IsInRole("Staff"))
			{
				var staff = _context.Staffs.FirstOrDefault(u => u.UserId == user.Id);
				if (staff == null)
				{
					return NotFound($"Unable to load staff with ID '{user.Id}'");
				}
				if (!ModelState.IsValid)
                {
					Load(user, staff, null, "Staff");
					return Page();
				}
				staff.ProfileImgUri = Input.ProfileImgUri;
                staff.FirstName = Input.FirstName;
                staff.LastName = Input.LastName;
                staff.NRIC = Input.NRIC;
                staff.Email = Input.Email;
                staff.ContactNumber = Input.ContactNumber;
				_context.Entry(staff).State = EntityState.Modified;
			}
			else if (User.IsInRole("Consumer"))
			{
				var consumer = _context.Consumers.FirstOrDefault(u => u.UserId == user.Id);
				if (consumer == null)
				{
					return NotFound($"Unable to load consumer with ID '{user.Id}'");
				}
				if (!ModelState.IsValid)
				{
					Load(user, null, consumer, "Consumer");
					return Page();
				}
				consumer.ProfileImgUri= Input.ProfileImgUri;
				consumer.FirstName = Input.FirstName;
				consumer.LastName = Input.LastName;
				consumer.NRIC = Input.NRIC;
				consumer.Email = Input.Email;
				consumer.ContactNumber = Input.ContactNumber;
				_context.Entry(consumer).State = EntityState.Modified;
			}
			else
			{
				return NotFound($"Unable to find role of user with ID '{user.Id}'.");
			}

			await _context.SaveChangesAsync();
			await _userManager.SetPhoneNumberAsync(user, Input.ContactNumber);
			await _userManager.SetEmailAsync(user, Input.Email);
			await _userManager.SetUserNameAsync(user, Input.Email);
			await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
