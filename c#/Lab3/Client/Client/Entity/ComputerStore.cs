﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace Client
{
    public class ComputerStore
    {
        [XmlArray("Computers"), XmlArrayItem("Computer")]
        public List<Computer> Computers { get; set; }

        public ComputerStore()
        {
            Computers = new List<Computer>();
        }
    }
}