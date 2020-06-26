using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace cw2.Models
{
    [Serializable]
    public class Uczelnia
    {
        public Uczelnia() { List<Student> students = new List<Student>(); }
        public List<Student> students { get; set; }
        [XmlAttribute("CreatedAt")]
        public string createdAt { get; set; }
        [XmlAttribute("Author")]
        public string author { get; set; }
    }
}
