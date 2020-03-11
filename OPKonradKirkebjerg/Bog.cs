using System;
using System.Data;

namespace OPKonradKirkebjerg
{
    public class Bog
    {
        private string _title;
        private string _author;
        private int _page;
        private string _isbn13;

        public string Title
        {
            get => _title;
            set { _title = value; }
        }

        public string Author
        {
            get => _author;
            set
            {
                if (value.Length < 2)
                {
                    throw  new ArgumentException();
                }

                _author = value;
            }
        }

        public int page
        {
            get => _page;
            set
            {
                if (_page <= 4 || _page >= 1000)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _page = value;
            }
        }

        public string Isbn13
        {
            get => _isbn13;
            set
            {
                if (value.Length < 12 || value.Length > 12)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _isbn13 = value;
            }
        }



    }
}
