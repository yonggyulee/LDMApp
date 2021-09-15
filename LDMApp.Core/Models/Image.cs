using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace LDMApp.Core.Models
{
    public class Image
    {
        [JsonPropertyName("imageID")]
        public string ImageID { get; set; }

        [JsonPropertyName("sampleID")]
        public int SampleID { get; set; }

        [JsonPropertyName("imageNO")]
        public int ImageNO { get; set; }

        [JsonPropertyName("imageCode")]
        public string ImageCode { get; set; }

        [JsonPropertyName("originalFilename")]
        public string OriginalFilename { get; set; }

        [JsonPropertyName("imageScheme")]
        public string ImageScheme { get; set; }

        public override string ToString()
        {
            return $"Image: ({ImageID}, {SampleID}, {ImageNO}, {ImageCode}, {OriginalFilename}, {ImageScheme})";
        }
    }
}
