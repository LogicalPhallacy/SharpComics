using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SharpComics.MetaData
{
    public class ComicInfoXML : IComicMetaDataParser, IMetaDataSerializer
    {
        private XmlSerializer Serializer = new XmlSerializer(typeof(ComicInfo));
        public ComicInfo ParseComicInfo(Stream fileStream)
        {
            ComicInfo info;
            info = (ComicInfo)Serializer.Deserialize(fileStream);
            return info;
        }

        public void SerializeMetadata(ref Stream stream, ComicInfo metadata)
        {  
            Serializer.Serialize(stream,metadata);
        }
    }
}
