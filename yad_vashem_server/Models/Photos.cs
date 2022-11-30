using System.Collections.Generic;

namespace yad_vashem_server.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Element_
    {
        public object id { get; set; }
        public string title { get; set; }
        public object text { get; set; }
        public object description { get; set; }
        public object credit { get; set; }
        public object source { get; set; }
        public object url { get; set; }
        public List<Image> images { get; set; }
    }

    public class Image
    {
        public string id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thmbnl { get; set; }
        public List<object> mapPointers { get; set; }
        public object backImage { get; set; }
        public string type { get; set; }
        public object vertices { get; set; }
        public object credit { get; set; }
        public object relatedLink { get; set; }
        public object marksPoints { get; set; }
    }

    public class Photos
    {
        public string title { get; set; }
        public object url { get; set; }
        public object urlTitle { get; set; }
        public string type { get; set; }
        public List<Element_> elements { get; set; }
    }


}
