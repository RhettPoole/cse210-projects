namespace RandomScripture
{
    public class Reference
    {
        private string _book;
        private string _chapter;
        private string _verse;
        private string _verseText;

        public Reference() { }

        public Reference(string book, string chapter, string verse, string verseText)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _verseText = verseText;
        }

        public string Book
        {
            get { return _book; }
            set { _book = value; }
        }

        public string Chapter
        {
            get { return _chapter; }
            set { _chapter = value; }
        }

        public string Verse
        {
            get { return _verse; }
            set { _verse = value; }
        }

        public string VerseText
        {
            get { return _verseText; }
            set { _verseText = value; }
        }
    }
}
