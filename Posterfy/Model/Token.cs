using System.Text.Json;

namespace Posterfy.Model
{
    public class Token
    {
        public string Access_Token { get; set; } = null;
        public string Token_Type { get; set; } = null;
        public int Expires_In { get; set; } = 0;

        public string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
