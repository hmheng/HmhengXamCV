using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HmhengXamCV.Core.Models
{
    public class WebResultsList
    {
        public string name { get; set; }
        public string webSearchUrl { get; set; }
        public uint totalEstimatedMatches { get; set; }
        public ObservableCollection<WebValueObject> value { get; set; }
        public bool someResultsRemoved { get; set; }
    }
}
