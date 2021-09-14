using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace LDMApp.Core.Models
{
    class Sample
    {
        [JsonPropertyName("sampleID")]
        public int SampleID { get; set; }

        [JsonPropertyName("datasetID")]
        public string DatasetID { get; set; }

        [JsonPropertyName("sampleType")]
        public int SampleType { get; set; }

        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }

        [JsonPropertyName("imageCount")]
        public int ImageCount { get; set; }

        [JsonPropertyName("images")]
        public List<Image> images { get; set; }
    }
}
