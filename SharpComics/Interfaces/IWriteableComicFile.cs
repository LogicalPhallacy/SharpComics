using System;
using System.Collections.Generic;
namespace SharpComics 
{
    public interface IWritableComicFile : IComicFile
    {
        void WriteMetadata(ComicInfo metadata, IComicMetadataProvider provider);
        void WritePages(IEnumerable<IComicPage> pages);
    }
}