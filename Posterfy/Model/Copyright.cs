using System.Text.Json;

namespace Posterfy.Model
{
    public class Copyright
    {
        public string Text { get; set; } = null;
        public string Type { get; set; } = null;

        public string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
