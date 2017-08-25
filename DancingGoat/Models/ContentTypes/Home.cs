// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace DancingGoat.Models
{
    public partial class Home
    {
        public const string Codename = "home";
        public const string HeroUnitCodename = "hero_unit";
        public const string ArticlesCodename = "articles";
        public const string OurStoryCodename = "our_story";
        public const string CafesCodename = "cafes";
        public const string ContactCodename = "contact";
        public const string UrlPatternCodename = "url_pattern";

        public IEnumerable<object> HeroUnit { get; set; }
        public IEnumerable<object> Articles { get; set; }
        public IEnumerable<object> OurStory { get; set; }
        public IEnumerable<object> Cafes { get; set; }
        public IRichTextContent Contact { get; set; }
        public string UrlPattern { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}