using System.Collections.Generic;
namespace SharpComics
{
    public interface IComicPage 
    {
        /// <summary>
        /// Will return a bytearray of the page
        /// </summary>
        /// <returns></returns>
        byte[] GetFileBytes();
    }
}