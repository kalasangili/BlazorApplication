using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorApp1.Components.Pages.FormValidation.Model
{
    public class FormData
    {
        [Required]
        public string? FullName { get; set; }

		[Required]
		public string? Degree { get; set; }

		[Required]
		public string? City { get; set; }

		[Required]
		public List<string>? Skills { get; set; }

		[Required]
		public string? Experience { get; set; }

		public long? CTC { get; set; }

		[Required]
		[Range (typeof(DateOnly), "1990-01-01","2006-12-30")]
		public DateOnly? DateOfBirth { get; set; }

		[Required]
		[Phone]
		public string? PhoneNumber { get; set; }

		[Required]
		[EmailAddress]
		public string? Email { get; set; }

		[Required]
		public string? UploadResume { get; set; }

		[Required]
		public string? UploadSign { get; set; }

	}
}
