using System.Xml.Serialization;

namespace SimpleMvcSitemap
{
    /// <summary>
    /// Defines a link between a document and an external resource.
    /// </summary>
    public class MobileXhtmlLink
    {
        internal MobileXhtmlLink() { }

        /// <summary>
        ///
        /// </summary>
        /// <param name="url">Specifies the location of the linked document.</param>
        public MobileXhtmlLink(string url)
        {
            Href = url;
        }

        /// <summary>
        /// Required. Specifies the relationship between the current document and the linked document.
        /// </summary>
        [XmlAttribute("rel")]
        public string Rel { get; set; }

        /// <summary>
        /// Specifies on what device the linked document will be displayed
        /// </summary>
        [XmlAttribute("media")]
        public string Media { get; set; }


        /// <summary>
        /// Specifies the location of the linked document.
        /// </summary>
        [XmlAttribute("href")]
        public string Href { get; set; }
    }
}