using System.Collections;
using System.Collections.Generic;
using System.IO;
using SharpCompress;

namespace SharpComics
{
    public class ZipCompressedComicFile : CompressedComicFile, IWritableComicFile
    {
        public ZipCompressedComicFile(FileInfo file) : base(file)
        {
            if(file.Exists)
            {
                comicFileAttributes = new List<ComicFileAttributes>{
                    ComicFileAttributes.Open,
                    ComicFileAttributes.Edit,
                    ComicFileAttributes.Paginate,
                    ComicFileAttributes.ReadMetaData,
                    ComicFileAttributes.WriteMetaData,
                    ComicFileAttributes.WriteMetaDataAsComment
                };
            }
        }
        private bool FileOpened;
        private bool CommentMetadata;
        //private ZipFile file;
        public override IEnumerable<string> FileExtensions => new string[] {
            "zip",
            "cbz"
        };
        internal override ComicInfo parseMetadata() 
        {
            using(var file = SharpCompress.Readers.Zip.ZipReader.Open(File.OpenRead(FileIdentifier)))
            {
                if(string.IsNullOrWhiteSpace(file.Volume.Comment))
                {

                }
            }
            return base.parseMetadata();
        }

        public override IEnumerable<ComicFileAttributes> Attributes => comicFileAttributes;

        public override IEnumerator<IComicPage> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        void IWritableComicFile.WriteMetadata(ComicInfo metadata, IComicMetadataProvider provider)
        {
            throw new System.NotImplementedException();
        }

        void IWritableComicFile.WritePages(IEnumerable<IComicPage> pages)
        {
            throw new System.NotImplementedException();
        }
    }
}