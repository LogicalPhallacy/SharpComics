using System;
using System.Collections.Generic;
using System.Text;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace SharpComics
{
    public class ComicPage
    {
        private int _imageindex;
        private string _fileName;
        private IImage _imagedata;

        public ComicPage(int imageIndex, string fileName)
        {
            _imageindex = imageIndex;
            _fileName = fileName;
        }

        public ComicPage(int imageIndex, string fileName, ComicPageInfo metaData)
        {
            _imageindex = imageIndex;
            _fileName = fileName;
            this.MetaData = metaData;
        }

        public ComicPage(string fileName, ComicPageInfo metaData)
        {
            _fileName = fileName;
            _imageindex = metaData.Image;
            this.MetaData = metaData;
        }

        public int ImageIndex
        {
            get
            {
                return _imageindex;
            }
            set
            {
                _imageindex = value;
            }
        }

        public string FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
            }
        }

        public ComicPageInfo MetaData;

        private IImageInfo LoadImageInfo(System.IO.Stream imagedata)
        {
            return Image.Identify(imagedata);
        }

        private IImage LoadImageData(System.IO.Stream imagedata)
        {
            return Image.Load(imagedata);
        }

        public IImage PageContent
        {
            get
            {
                return _imagedata;
            }
        }

        public void ParseMetadata(System.IO.Stream imagedata)
        {
            var meta = new ComicPageInfo();
            meta.Image = ImageIndex;
            var imageInfo = LoadImageInfo(imagedata);
            meta.ImageHeight = imageInfo.Height;
            meta.ImageWidth = imageInfo.Width;

            MetaData = meta;
        }

        public void LoadImage(System.IO.Stream imagedata)
        {
            _imagedata = LoadImageData(imagedata);
        }
    }
}
