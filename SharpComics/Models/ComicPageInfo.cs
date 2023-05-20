using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SharpComics
{
    [Serializable]
    public class ComicPageInfo
    {
        private int _imageindex = -1;
        private int _imagewidth = -1;
        private int _imageheight = -1;
        private PageType _pageType;
        private int _imageSize = -1;
        private bool? _doublepage;
        private string _key = string.Empty;

        [XmlAttribute]
        public int Image
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
        [XmlAttribute]
        public PageType Type
        {
            get
            {
                return _pageType;
            }
            set
            {
                _pageType = value;
            }
        }

        [XmlAttribute]
        public bool DoublePage
        {
            get
            {
                return (bool)_doublepage;
            }
            set
            {
                _doublepage = value;
            }
        }
        public bool DoublePageSpecified
        {
            get
            {
                return _doublepage != null;
            }
        }

        [XmlAttribute]
        public int ImageSize
        {
            get
            {
                return _imageSize;
            }
            set
            {
                _imageSize = value;
            }
        }
        [XmlAttribute]
        public string Key
        {
            get
            {
                return _key;
            }
            set
            {
                _key = value;
            }
        }
        [XmlAttribute]
        public int ImageWidth
        {
            get
            {
                return _imagewidth;
            }
            set
            {
                _imagewidth = value;
            }
        }
        [XmlAttribute]
        public int ImageHeight
        {
            get
            {
                return _imageheight;
            }
            set
            {
                _imageheight = value;
            }
        }

    }
    [Serializable]
    public enum PageType
    {
        FrontCover,
        InnerCover,
        Roundup,
        Story,
        Advertisement,
        Editorial,
        Letters,
        Preview,
        BackCover,
        Other,
        Deleted
    }
}
