using System.Text.Json;

namespace Posterfy.Model
{
    public class ExternalId
    {
        public string Upc { get; set; } = null;
        public string Isrc { get; set; } = null;
        public string Ean { get; set; } = null;

        public string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
