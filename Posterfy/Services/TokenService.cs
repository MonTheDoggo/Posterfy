using Newtonsoft.Json;
using Posterfy.Model;

namespace Posterfy.Services
{
    public class TokenService
    {
        private readonly string tokenUrl = "https://accounts.spotify.com/api/token";
        private string clientId = "";
        private string clientSecret = "";
        public Token Token { get; set; } = new Token();
        public async Task GetToken()
        {
            await SetClientValues();
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

        private async Task SetClientValues()
        {
            var client = JsonConvert.DeserializeObject<ClientValue>(await File.ReadAllTextAsync(@"Secrets/secrets.json"));
            clientId = client.ClientId;
            clientSecret = client.ClientSecret;
        }
    }
}
