using System;
using System.IO;
using SharpComics;
using System.CommandLine;
using System.Threading.Tasks;

namespace comictag
{
    class Program
    {
        static async Task Main(string[] args)
        {
            RootCommand rootCommand = new RootCommand(
                "comictag can read and (maybe) manipulate tags for common digital comic formats"
            );
        }

        static void ParseLibrary(FileInfo libraryFile)
        {

        }
    }
}
