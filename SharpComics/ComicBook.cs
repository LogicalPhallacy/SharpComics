using System;
using SharpCompress;
using SharpCompress.Archives;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using SharpComics.MetaData;
using System.IO;
using System.Collections;

namespace SharpComics
{
    public class ComicBook : IEnumerable<ComicPage>
    {
        public String FileName;
        public ComicInfo MetaData;
        public Dictionary<int,ComicPage> Pages;

        private const string ImageRegex = @"([^\s]+(\.(?i)(jpg|png|gif|bmp))$)";
        private FileInfo _comicFileInfo;

        public ComicBook(string fileName)
        {
            Pages = new Dictionary<int, ComicPage>();
            FileName = fileName;
            if (File.Exists(fileName))
            {
                _comicFileInfo = new FileInfo(fileName);
            }
            else
            {
                throw new FileNotFoundException("Comic file not found",fileName);
            }
            ParsePages();
        }

        private void ParsePages()
        {
            using (var archive = ArchiveFactory.Open(_comicFileInfo))
            {
                var pageentries = archive.Entries.Where((entry) => { return Regex.IsMatch(entry.Key, ImageRegex); });
                for(int i = 1; i <= pageentries.Count(); i++)
                {
                    Pages.Add(i, new ComicPage(i, pageentries.ElementAt(i).Key));
                }
            }
        }

        public void ParseMetadata()
        {
            IComicMetaDataParser parser = null;
            IArchive archive = null;
            Stream filestream = null;
            bool shouldParse = false;
            try
            {
                archive = ArchiveFactory.Open(_comicFileInfo);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Couldn't Open Archive: {FileName}");
                Console.WriteLine($"Exception {e.Message}");
                return;
            }

            // Check for ComicInfo.XML
            var xmlinfo = archive.Entries.First((entry) => { return entry.Key.ToLowerInvariant().Equals("comicinfo.xml");});
            if (xmlinfo != null)
            {
                parser = new ComicInfoXML();
                filestream = xmlinfo.OpenEntryStream();
                shouldParse = true;
            }

            //TODO: Other Formats


            if (shouldParse)
            {
                this.MetaData = parser.ParseComicInfo(filestream);
                if (filestream != null)
                    filestream.Dispose();
            }

            archive.Dispose();
        }

        public void ParsePageMetadata()
        {
            foreach (var page in MetaData.Pages)
            {
                if (Pages.ContainsKey(page.Image))
                {
                    Pages[page.Image].MetaData = page;
                }
            }
            using (var comicFile = ArchiveFactory.Open(fileInfo: _comicFileInfo))
            {
                foreach (var page in Pages.Values)
                {
                
                    if (page.MetaData == null)
                    {
                        using(var stream = comicFile.Entries.Where((entry) => { return entry.Key == page.FileName; }).First().OpenEntryStream())
                        {
                            page.ParseMetadata(stream);
                        }
                    }
                }
            }
        }

        public IEnumerator<ComicPage> GetEnumerator()
        {
            foreach (var kvp in Pages)
            {
                yield return kvp.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
