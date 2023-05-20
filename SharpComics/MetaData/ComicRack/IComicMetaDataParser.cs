using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SharpComics.MetaData
{
    interface IComicMetaDataParser
    {
        ComicInfo ParseComicInfo(Stream metaDataStream);
    }
}
