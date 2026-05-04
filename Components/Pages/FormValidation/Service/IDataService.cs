using BlazorApp1.Components.Pages.FormValidation.Model;

namespace BlazorApp1.Components.Pages.FormValidation.Service
{
    public interface IDataService
    {
        public void SendData(FormData formData);
        public List<FormData> GetData();

        public FormData GetDataByName(string userName);
    }
}
