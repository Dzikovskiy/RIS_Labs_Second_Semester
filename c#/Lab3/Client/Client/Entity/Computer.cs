﻿using System;
 using System.Xml.Serialization;

namespace Client
{
    public class Computer
    {
        [XmlAttribute("Brand")] public string Brand { get; set; }
        [XmlAttribute("Price")] public String Price { get; set; }
        [XmlAttribute("Id")] public String Id { get; set; }

        public override string ToString()
        {
            return Brand + " " + Price;
        }
    }
}