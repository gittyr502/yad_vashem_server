using System.Collections.Generic;

namespace yad_vashem_server.Models
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Element
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string birthYear { get; set; }
        public string placeOfResidence { get; set; }
        public string source { get; set; }
        public string url { get; set; }
    }

    public class Names
    {
        public string title { get; set; }
        public string url { get; set; }
        public string urlTitle { get; set; }
        public string type { get; set; }
        public List<Element> elements { get; set; }
    }


}
