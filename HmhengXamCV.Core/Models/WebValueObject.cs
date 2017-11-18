using System;
using System.Collections.Generic;
using System.Text;

namespace HmhengXamCV.Core.Models
{
    public class WebValueObject
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string displayUrl { get; set; }
        public string snippet { get; set; }
        public string dateLastCrawled { get; set; }
        public List<SearchTagsObj> searchTags { get; set; }
    }
}
