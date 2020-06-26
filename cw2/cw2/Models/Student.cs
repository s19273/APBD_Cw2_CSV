using System;
using System.Xml.Serialization;

namespace cw2.Models
{

    [Serializable]
    public class Student
    {
        [XmlAttribute(attributeName: "indexNumber")]
        public string indexNumber { get; set; }

        [XmlAttribute(attributeName: "fname")]
        public string name { get; set; }

        [XmlAttribute(attributeName: "lname")]
        public string lastName { get; set; }

        [XmlAttribute(attributeName: "birthdate")]
        public DateTime birthdate { get; set; }

        [XmlAttribute(attributeName: "email")]
        public string email { get; set; }

        [XmlAttribute(attributeName: "mothersName")]
        public string mothersName { get; set; }

        [XmlAttribute(attributeName: "fathersName")]
        public string fathersName { get; set; }

        [XmlAttribute(attributeName: "studiesName")]
        public string studiesName { get; set; }

        [XmlAttribute(attributeName: "studiesMode")]
        public string studiesMode { get; set; }
        public override string ToString()
        {
            return base.ToString() + ": " + name + " " + lastName + " " + indexNumber;
        }

        public bool Equals(Student s)
        {
            if (this.indexNumber == s.indexNumber && this.name.Equals(s.name) && this.lastName.Equals(s.lastName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
