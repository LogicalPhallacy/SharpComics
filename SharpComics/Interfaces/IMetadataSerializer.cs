using System.IO;
namespace SharpComics
{
    public interface IMetaDataSerializer 
    {
        /// <summary>
        /// Returns a serialized string representing the Comic's metadata
        /// </summary>
        /// <param name="metdata"></param>
        /// <returns></returns>
        void SerializeMetadata(ref Stream stream, ComicInfo metdata);
    }
}