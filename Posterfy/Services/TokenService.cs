using Newtonsoft.Json;
using Posterfy.Model;

namespace Posterfy.Services
{
    public class TokenService
    {
        private readonly string tokenUrl = "https://accounts.spotify.com/api/token";
        public Token Token { get; set; } = new Token();
        public async Task GetToken()
        {
            var base64Auth = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}"));

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Basic {base64Auth}");
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials"),
                new KeyValuePair<string, string>("Content-Type", "application/x-www-form-urlencoded")
            });
            var response = await client.PostAsync(tokenUrl, content);
            var responseContent = await response.Content.ReadAsStringAsync();
            Token = JsonConvert.DeserializeObject<Token>(responseContent);
        }
    }
}
