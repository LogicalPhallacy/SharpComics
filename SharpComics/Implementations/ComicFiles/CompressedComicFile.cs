using System.Collections;
using System.Collections.Generic;
using System.IO;
using SharpCompress.Archives;
namespace SharpComics
{
    public abstract class CompressedComicFile : IComicFile
    {
        public CompressedComicFile(FileInfo file)
        {
            this.filePath = file;
            comicFileAttributes = new List<ComicFileAttributes>{ComicFileAttributes.Dummy};
        }
        private FileInfo filePath;
        private ComicInfo info = null;
        public string FileIdentifier 
        { 
            get => filePath.FullName; 
            set => filePath = new FileInfo(value); 
        }

        internal IEnumerable<ComicFileAttributes> comicFileAttributes;

        public abstract IEnumerable<string> FileExtensions {get;}

        public virtual ComicInfo MetaData {get => parseMetadata();}

        internal virtual IEnumerable<string> getFiles()
        {
            using (var archive = SharpCompress.Archives.ArchiveFactory.Open(File.OpenRead(filePath.FullName)))
            {
                foreach(var entry in archive.Entries)
                {
                    yield return entry.Key;
                }
            }
        }
        internal virtual ComicInfo parseMetadata()
        {
            if(info == null)
            {
                foreach(var file in getFiles())
                {

                }
            }
            else
            {
                return info;
            }
        }
        public virtual IEnumerable<ComicFileAttributes> Attributes {get => comicFileAttributes}

        public abstract IEnumerator<IComicPage> GetEnumerator();

        public byte[] GetFileBytes()
        {
            return File.ReadAllBytes(filePath.FullName);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}