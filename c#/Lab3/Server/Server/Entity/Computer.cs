using System.Xml.Serialization;

namespace Server
{
    public class Computer
    {
        [XmlAttribute("Brand")] public string Brand { get; set; }
        [XmlAttribute("Price")] public string Price { get; set; }
        [XmlAttribute("Id")] public string Id { get; set; }

    }
}