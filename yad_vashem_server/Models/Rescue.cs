using System.Collections.Generic;

namespace yad_vashem_server.Models
{
    public class Detail
    {
        public string title { get; set; }
        public List<Value> value { get; set; }
    }

    public class Elements
    {
        public List<Detail> details { get; set; }
        public Map map { get; set; }
        public Links links { get; set; }
    }

    public class Links
    {
        public string title { get; set; }
        public List<Value> value { get; set; }
    }

    public class Map
    {
        public List<Pointer> pointers { get; set; }
        public List<Place> places { get; set; }
    }

    public class Place
    {
        public string lif { get; set; }
        public List<string> places { get; set; }
        public string point { get; set; }
    }

    public class Pointer
    {
        public string icon { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string title { get; set; }
    }

    public class Rescue
    {
        public string title { get; set; }
        public object url { get; set; }
        public object urlTitle { get; set; }
        public string type { get; set; }
        public Elements elements { get; set; }
    }

    public class Value
    {
        public string id { get; set; }
        public string value { get; set; }
        public object url { get; set; }
    }


}
