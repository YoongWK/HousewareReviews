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
using Microsoft.AspNetCore.Components.Forms;
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
		/// 
		public string ProfileImgUri { get; set; }
		public string Username { get; set; }
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
			[Display(Name = "Profile Image File")]
			public IFormFile ProfileImgFile { get; set; }

			[Required(ErrorMessage = "First Name is required.")]
			[Display(Name = "First Name")]
			public string FirstName { get; set; }

			[Required(ErrorMessage = "Last Name is required.")]
			[Display(Name = "Last Name")]
			public string LastName { get; set; }

			[Required(ErrorMessage = "Email is required.")]
			[EmailAddress(ErrorMessage = "Email is not valid.")]
			[Display(Name = "Email")]
			public string Email { get; set; }

			[Required(ErrorMessage = "Contact Number is required.")]
			[DataType(DataType.PhoneNumber)]
			[RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not valid.")]
			[Display(Name = "Contact Number")]

			public string ContactNumber { get; set; }
			[StringLength(100, ErrorMessage = "Password must be {2} to {1} characters long.", MinimumLength = 6)]
			[DataType(DataType.Password)]
			[Display(Name = "New password")]

			public string NewPassword { get; set; }
			[DataType(DataType.Password)]
			[Display(Name = "Current password")]
			public string OldPassword { get; set; }
		}

		private async Task LoadAsync(ApplicationUser user, Staff staff, Consumer consumer, string role)
		{
			var userName = await _userManager.GetUserNameAsync(user);
			Username = userName;

			var firstName = "";
			var lastName = "";
			var email = "";
			var contactNumber = "";

			if (role == "Staff")
			{
				ProfileImgUri = staff.ProfileImgUri;
				firstName = staff.FirstName;
				lastName = staff.LastName;
				email = staff.Email;
				contactNumber = staff.ContactNumber;
			}
			else if (role == "Consumer")
			{
				ProfileImgUri = consumer.ProfileImgUri;
				firstName = consumer.FirstName;
				lastName = consumer.LastName;
				email = consumer.Email;
				contactNumber = consumer.ContactNumber;
			}
			Input = new InputModel
			{
				FirstName = firstName,
				LastName = lastName,
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
                await LoadAsync(user, staff, null, "Staff");
			}
            else if (User.IsInRole("Consumer"))
            {
                var consumer = _context.Consumers.FirstOrDefault(u => u.UserId == user.Id);
                if (consumer == null)
                {
                    return NotFound($"Unable to load consumer with ID '{user.Id}'");
                }
				await LoadAsync(user, null, consumer, "Consumer");
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

			if (Input.ProfileImgFile != null)
			{
				using (var ms = new MemoryStream())
				{
					Input.ProfileImgFile.CopyTo(ms);
					var fileBytes = ms.ToArray();
					ProfileImgUri = $"data:image/png;base64,{Convert.ToBase64String(fileBytes)}";
				}
			}

			if (Input.NewPassword != null)
			{
				var changePasswordResult = await _userManager.ChangePasswordAsync(user, Input.OldPassword == null? "" : Input.OldPassword, Input.NewPassword);
				if (!changePasswordResult.Succeeded)
				{
					foreach (var error in changePasswordResult.Errors)
					{
						ModelState.AddModelError(string.Empty, error.Description);
					}
				}
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
					await LoadAsync(user, staff, null, "Staff");
					return Page();
				}
				staff.ProfileImgUri = ProfileImgUri == null? staff.ProfileImgUri : ProfileImgUri;
                staff.FirstName = Input.FirstName;
                staff.LastName = Input.LastName;
                staff.Email = Input.Email;
                staff.ContactNumber = Input.ContactNumber;
				staff.Password = Input.NewPassword == null? staff.Password : Input.NewPassword;
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
					await LoadAsync(user, null, consumer, "Consumer");
					return Page();
				}
				consumer.ProfileImgUri= ProfileImgUri == null ? consumer.ProfileImgUri : ProfileImgUri;
				consumer.FirstName = Input.FirstName;
				consumer.LastName = Input.LastName;
				consumer.Email = Input.Email;
				consumer.ContactNumber = Input.ContactNumber;
				consumer.Password = Input.NewPassword == null ? consumer.Password : Input.NewPassword;
				_context.Entry(consumer).State = EntityState.Modified;
			}
			else
			{
				return NotFound($"Unable to find role of user with ID '{user.Id}'.");
			}

			await _userManager.SetPhoneNumberAsync(user, Input.ContactNumber);
			await _userManager.SetEmailAsync(user, Input.Email);
			await _context.SaveChangesAsync();
			await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
