using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SharpComics.MetaData
{
    public class ComicInfoXML : IComicMetaDataParser
    {
        public ComicInfo ParseComicInfo(Stream fileStream)
        {
            ComicInfo info;
            var Serializer = new XmlSerializer(typeof(ComicInfo));
            info = (ComicInfo)Serializer.Deserialize(fileStream);
            return info;
        }
    }
}
