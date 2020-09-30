using JobToApp.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace JobToApp.Services
{
    public class UserService : APIService
    {
        public async Task<User> RegisterUser(string username, string password)
        {
            return new User();
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var keyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("client_id", "xamarinui"),
                new KeyValuePair<string, string>("client_secret", "no_password")
            };

            var request = new HttpRequestMessage(HttpMethod.Post, "https://jobtoapp.azurewebsites.net/connect/token");

            request.Content = new FormUrlEncodedContent(keyValues);

            var client = new HttpClient();
            var response = await client.SendAsync(request);
            var userJson = await response.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<User>(userJson);
            Preferences.Set("access_token", user.AccessToken);
            Preferences.Set("expires_in", user.ExpiresIn);
            Preferences.Set("scope", user.Scope);
 
            return response.IsSuccessStatusCode;
        }
    }
}
