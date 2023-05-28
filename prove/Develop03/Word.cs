namespace RandomScripture
{
    public class Word
    {
        private string _word;
        private bool _isShown;

        public Word()
        {
        }

        public Word(string word)
        {
            _word = word;
        }

        public Word(string word, bool isShown)
        {
            _word = word;
            _isShown = isShown;
        }

        public string WordValue
        {
            get { return _word; }
            set { _word = value; }
        }

        public bool IsShown
        {
            get { return _isShown; }
            set { _isShown = value; }
        }
    }
}
