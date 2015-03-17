using System.Xml.Serialization;

namespace SimpleMvcSitemap
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot("url", Namespace = Namespaces.Sitemap)]
    public class SiteMapLink
    {
        internal SiteMapLink() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        public SiteMapLink(string url)
        {
            Href = url;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("rel")]
        public string Rel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("media")]
        public string Media { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("href")]
        public string Href { get; set; }
    }
}