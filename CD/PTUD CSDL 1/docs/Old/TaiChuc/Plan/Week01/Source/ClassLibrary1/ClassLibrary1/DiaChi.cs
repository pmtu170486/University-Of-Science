using System;
using System.Collections.Generic;
using System.Text;
using Telerik.OpenAccess;
namespace ClassLibrary1
{
    [Telerik.OpenAccess.Persistent]
    public class DiaChi
    {
        private string Duong;
        [System.Xml.Serialization.XmlElement(ElementName="Street")]
        public string Duong1
        {
            get { return Duong; }
            set { Duong = value; }
        }
        private string Quan;
        [System.Xml.Serialization.XmlElement(ElementName = "Ward")]
        public string Quan1
        {
            get { return Quan; }
            set { Quan = value; }
        }
    }
}
