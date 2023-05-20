using System;
using System.Collections.Generic;
namespace SharpComics 
{
    public interface IComicFile : IEnumerable<IComicPage>
    {
        /// <summary>
        /// The friendly identifier for the file (usually a path)
        /// </summary>
        /// <value></value>
        string FileIdentifier {get; set;}
        /// <summary>
        /// Valid extensions for this comic file
        /// </summary>
        /// <value></value>
        IEnumerable<string> FileExtensions{get;}
        /// <summary>
        /// Returns the metadata of the Comic FIle
        /// </summary>
        /// <value></value>
        ComicInfo MetaData {get;}
        /// <summary>
        /// An IEnumerable full of ComicFileAttributes for the Comic File listing its capabilities
        /// </summary>
        /// <value></value>
        IEnumerable<ComicFileAttributes> Attributes{get;}
        /// <summary>
        /// Will return a bytearray of the complete ComicFile
        /// </summary>
        /// <returns></returns>
        byte[] GetFileBytes();
        IEnumerable<IComicMetadataProvider> metadataProviders{get;}
    }
}