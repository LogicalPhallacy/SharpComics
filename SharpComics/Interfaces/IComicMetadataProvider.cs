using System.IO;
namespace SharpComics
{
    public interface IComicMetadataProvider
    {
        public bool WritesMetadata{get;}
        public ComicInfo GetMetadata(Stream metadataStream);
        public void WriteMetadata(ComicInfo comicInfo);
    }
}