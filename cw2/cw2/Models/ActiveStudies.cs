using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace cw2.Models
{
    public class ActiveStudies
    {
           
        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute]
        public int numberOfStudents { get; set; }
    }
}

