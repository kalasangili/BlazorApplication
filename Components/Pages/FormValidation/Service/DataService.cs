using BlazorApp1.Components.Pages.FormValidation.Model;
using System.Collections.Generic;

namespace BlazorApp1.Components.Pages.FormValidation.Service
{
    public class DataService : IDataService
    {
		List<FormData> FormDetails = new List<FormData>();

		private FormData formData { get; set; }
        public void SendData(FormData formData)
        {
			var AppliedData = new FormData()
			{
				FullName = formData.FullName,
				Degree = formData.Degree,
				City = formData.City,
				Skills = formData.Skills,
				Experience = formData.Experience,
				CTC = formData.CTC,
				DateOfBirth = formData.DateOfBirth,
				PhoneNumber = formData.PhoneNumber,
				Email = formData.Email,
				UploadResume = formData.UploadResume,
				UploadSign = formData.UploadSign
			};
			FormDetails.Add(AppliedData);
			//return formData;
		}

		public List<FormData> GetData()
		{
			return FormDetails;
		}

	}
}
