using System.Net.Http;
using System.Net.Http.Headers;
using Xamarin.Essentials;

namespace JobToApp.Services
{
    public abstract class APIService
    {
        protected HttpClient _client;
        protected string _baseApiUrl;
        public APIService()
        {
            _client = new HttpClient();
            if (Preferences.ContainsKey("access_token") && !string.IsNullOrEmpty(Preferences.Get("access_token", "")))
            {
                var token = Preferences.Get("access_token", "");
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }            
        }
    }
}
