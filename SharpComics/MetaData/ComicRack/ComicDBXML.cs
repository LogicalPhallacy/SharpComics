using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SharpComics.MetaData
{
    public class ComicDBXML
    {
        public string FileName;
        public List<Book> Comics;
        public ComicDBXML(string fileName)
        {
            FileName = fileName;
            Comics = new List<Book>();
        }

        public class Book : ComicInfo
        {
            [XmlAttribute]
            public Guid Id;
            [XmlAttribute(AttributeName="File")]
            public string FileName;
        }

        //[XmlRoot("ComicDatabase")]
        public class BookLibrary
        {
            [XmlArrayItem]
            public List<Book> Books;
        }

        public void Parse()
        {
            var Serializer = new XmlSerializer(typeof(BookLibrary),new XmlRootAttribute("ComicDatabase"));
            using (var stream = new FileStream(FileName, FileMode.Open))
            {
                var books = (BookLibrary)Serializer.Deserialize(stream);
                Comics = books.Books;
            }
        }
    }
}
