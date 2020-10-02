using System.Xml.Serialization;

namespace RisLab2
{
    public class Computer
    {
        [XmlAttribute("Brand")] public string Brand { get; set; } 

        [XmlAttribute("Price")] public int Price { get; set; } 

        
    }
}