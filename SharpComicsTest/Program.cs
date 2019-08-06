using System;
using SharpComics;

namespace CBReaderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string ComicLib = "C:\\path\\to\\ComicDB.xml";
            string ComicPath = "C:path\\to\\comic.cbz";
            //Console.WriteLine($"Testing with {ComicPath}");
            //ComicBook comicBook = new ComicBook(ComicPath);
            //comicBook.ParseMetadata();
            //comicBook.ParsePageMetadata();
            SharpComics.MetaData.ComicDBXML comicDBXML = new SharpComics.MetaData.ComicDBXML(ComicLib);
            Console.WriteLine("Parsing Library, fingers crossed");
            comicDBXML.Parse();

            Console.WriteLine("SHOW US WHAT YOU GOT");
        }
    }
}
