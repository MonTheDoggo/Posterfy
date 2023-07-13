using System.Text.Json;

namespace Posterfy.Model
{
    public class Album
    {
        public string Album_Type { get; set; } = null;
        public Artist[] Artists { get; set; } = null;
        public string[] Available_Markets { get; set; } = null;
        public Copyright[] Copyrights { get; set; } = null;
        public ExternalId External_Ids { get; set; } = null;
        public ExternalUrl External_Urls { get; set; } = null;
        public string[] Genres { get; set; } = null;
        public string Href { get; set; } = null;
        public string Id { get; set; } = null;
        public Image[] Images { get; set; } = null;
        public string Label { get; set; } = null;
        public string Name { get; set; } = null;
        public int Popularity { get; set; } = 0;
        public string Release_Date { get; set; } = null;
        public string Release_Date_Precision { get; set; } = null;
        public int Total_Tracks { get; set; } = 0;
        public Track Tracks { get; set; } = null;
        public string Type { get; set; } = null;
        public string Uri { get; set; } = null;

        public string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
