using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SharpComics
{
    [Serializable]
    public class ComicInfo
    {
        private string _series = string.Empty;
        private string _title = string.Empty;
        private string _number = string.Empty;
        private int _count = -1;
        private int _volume = -1;
        private string _altseries = string.Empty;
        private string _altnumber = string.Empty;
        private int _altCount = -1;
        private string _summary = string.Empty;
        private string _notes = string.Empty;
        private int _year = -1;
        private int _month = -1;
        private int _day = -1;
        private string _publisher = string.Empty;
        private string _imprint = string.Empty;
        private string _genre = string.Empty;
        private string _web = string.Empty;
        private string _languageISO = string.Empty;
        private string _format = string.Empty;
        private string _manga = string.Empty;
        private string _characters = string.Empty;
        private string _teams = string.Empty;
        private string _locations = string.Empty;
        private int _pageCount;
        private string _scanInformation = string.Empty;
        private string _storyArc = string.Empty;
        private string _seriesGroup = string.Empty;
        private string _ageRating = string.Empty;
        private string _blackandwhite = string.Empty;

        private string _review = string.Empty;
        private string _writer = string.Empty;
        private string _penciller = string.Empty;
        private string _inker = string.Empty;
        private string _colorist = string.Empty;
        private string _letterer = string.Empty;
        private string _coverArtist = string.Empty;
        private string _editor = string.Empty;

        private string _mainCharacterOrTeam = string.Empty;

        private List<ComicPageInfo> _pages;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public string Series
        {
            get
            {
                return _series;
            }
            set
            {
                _series = value;
            }
        }




        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }
        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = value;
            }
        }

        public string AlternateSeries
        {
            get
            {
                return _altseries;
            }
            set
            {
                _altseries = value;
            }
        }




        public string AlternateNumber
        {
            get
            {
                return _altnumber;
            }
            set
            {
                _altnumber = value;
            }
        }





        public string StoryArc
        {
            get
            {
                return _storyArc;
            }
            set
            {
                _storyArc = value;
            }
        }





        public string SeriesGroup
        {
            get
            {
                return _seriesGroup;
            }
            set
            {
                _seriesGroup = value;
            }
        }

        public int AlternateCount
        {
            get
            {
                return _altCount;
            }
            set
            {
                _altCount = value;
            }
        }




        public string Summary
        {
            get
            {
                return _summary;
            }
            set
            {
                _summary = value;
            }
        }




        public string Notes
        {
            get
            {
                return _notes;
            }
            set
            {
                _notes = value;
            }
        }




        public string Review
        {
            get
            {
                return _review;
            }
            set
            {
                _review = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public int Month
        {
            get
            {
                return _month;
            }
            set
            {
                _month = value;
            }
        }

        public int Day
        {
            get
            {
                return _day;
            }
            set
            {
                _day = value;
            }
        }

        public string Writer
        {
            get
            {
                return _writer;
            }
            set
            {
                _writer = value;
            }
        }

        public string Penciller
        {
            get
            {
                return _penciller;
            }
            set
            {
                _penciller = value;
            }
        }

        public string Inker
        {
            get
            {
                return _inker;
            }
            set
            {
                _inker = value;
            }
        }

        public string Colorist
        {
            get
            {
                return _colorist;
            }
            set
            {
                _colorist = value;
            }
        }





        public string Letterer
        {
            get
            {
                return _letterer;
            }
            set
            {
                _letterer = value;
            }
        }





        public string CoverArtist
        {
            get
            {
                return _coverArtist;
            }
            set
            {
                _coverArtist = value;
            }
        }





        public string Editor
        {
            get
            {
                return _editor;
            }
            set
            {
                _editor = value;
            }
        }





        public string Publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
            }
        }

        public string Imprint
        {
            get
            {
                return _imprint;
            }
            set
            {
                _imprint = value;
            }
        }





        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
            }
        }

        public string Web
        {
            get
            {
                return _web;
            }
            set
            {
                _web = value;
            }
        }

        public int PageCount
        {
            get
            {
                return _pageCount;
            }
            set
            {
                _pageCount = value;
            }
        }



        public string LanguageISO
        {
            get
            {
                return _languageISO;
            }
            set
            {
                _languageISO = value;
            }
        }

        public string Format
        {
            get
            {
                return _format;
            }
            set
            {
                _format = value;
            }
        }

        public string AgeRating
        {
            get
            {
                return _ageRating;
            }
            set
            {
                _ageRating = value;
            }
        }

        public string BlackAndWhite
        {
            get
            {
                return _blackandwhite;
            }
            set
            {
                _blackandwhite = value;
            }
        }


        public string Manga
        {
            get
            {
                return _manga;
            }
            set
            {
                _manga = value;
            }
        }

        public string Characters
        {
            get
            {
                return _characters;
            }
            set
            {
                _characters = value;
            }
        }

        public string Teams
        {
            get
            {
                return _teams;
            }
            set
            {
                _teams = value;
            }
        }

        public string MainCharacterOrTeam
        {
            get
            {
                return _mainCharacterOrTeam;
            }
            set
            {
                _mainCharacterOrTeam = value;
            }
        }

        public string Locations
        {
            get
            {
                return _locations;
            }
            set
            {
                _locations = value;
            }
        }

        public string ScanInformation
        {
            get
            {
                return _scanInformation;
            }
            set
            {
                _scanInformation = value;
            }
        }

        [XmlArrayItem("Page")]
        public List<ComicPageInfo> Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                _pages = value;
            }
        }
    }
}
