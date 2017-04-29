using System;
using System.Collections.Generic;
using System.Text;
using Telerik.OpenAccess;
namespace ClassLibrary1
{
    [Telerik.OpenAccess.Persistent(Alias="DG")]
    public class DocGia:DiaChi
    {
        private string hoten;
        [System.Xml.Serialization.XmlElement(ElementName = "name")]
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        private int code;
        [System.Xml.Serialization.XmlElement(ElementName = "IDCode")]
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public DocGia KiemTraDocGia(int code)
        {
            DocGia dg = new DocGia();
            DiaChi d = new DiaChi();
            IObjectScope scope = ObjectScopeProvider1.GetNewObjectScope();
            scope.Transaction.Begin();
            d.Duong1 = "Nguyen van cu";
            d.Quan1 = "1";
            scope.Add(d);
            dg.Hoten = "Tu";
            dg.code = 1;
            dg.Duong1 = "fs";
            dg.Quan1 = "1";
            scope.Add(dg);
            scope.Transaction.Commit();
            return dg;
        }

    }
}
