using System;

namespace VerseHider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScriptureReference reference = new ScriptureReference("2 Nephi ", "9: ", "10", "O how great the goodness of our God, who prepareth a way for our escape from the grasp of this awful monster; yea, that monster, death and hell, which I call the death of the body, and also the death of the spirit.");
            ScriptureDisplay scriptureDisplay = new ScriptureDisplay(reference);
            string userInput = string.Empty;

            Console.WriteLine("Welcome to Verse Hider!\n");
            Console.WriteLine(scriptureDisplay.GetVisibleText());
            Console.WriteLine("\nPress Enter to hide random words or type 'quit' to exit: ");
            userInput = Console.ReadLine();

            while (userInput.ToLower() != "quit")
            {
                Console.Clear();
                scriptureDisplay.HideWords();
                Console.WriteLine("Welcome to Verse Hider!\n");
                Console.WriteLine(scriptureDisplay.GetVisibleText());
                Console.WriteLine("\nPress Enter to hide random words or type 'quit' to exit: ");
                userInput = Console.ReadLine();

                if (scriptureDisplay.IsFullyHidden())
                {
                    userInput = "quit";
                }
            }
        }
    }
}

namespace VerseHider
{
    public class ScriptureReference
    {
        private string _book;
        private string _chapter;
        private string _verse;
        private string _verseText;

        public ScriptureReference(string book, string chapter, string verse, string verseText)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _verseText = verseText;
        }

        public string GetBook()
        {
            return _book;
        }

        public string GetChapter()
        {
            return _chapter;
        }

        public string GetVerse()
        {
            return _verse;
        }

        public string GetVerseText()
        {
            return _verseText;
        }
    }
}

namespace VerseHider
{
    public class ScriptureDisplay
    {
        private string _visibleText;
        private string _hiddenText;

        public ScriptureDisplay(ScriptureReference reference)
        {
            _visibleText = $"{reference.GetBook()} {reference.GetChapter()}:{reference.GetVerse()} {reference.GetVerseText()}";
            _hiddenText = GenerateHiddenText(reference.GetVerseText());
        }

        public void HideWords()
        {
            // Randomly hide words in the hidden text
            Random random = new Random();
            string[] words = _hiddenText.Split(' ');
            int wordsToHide = Math.Min(words.Length, 3);

            for (int i = 0; i < wordsToHide; i++)
            {
                int randomIndex = random.Next(0, words.Length);
                words[randomIndex] = GenerateUnderlines(words[randomIndex]);
            }

            _hiddenText = string.Join(" ", words);
        }

        public string GetVisibleText()
        {
            return _visibleText;
        }

        public bool IsFullyHidden()
        {
            return !_hiddenText.Contains("_");
        }

        private string GenerateUnderlines(string word)
        {
            return new string('_', word.Length);
        }

        private string GenerateHiddenText(string verseText)
        {
            string[] words = verseText.Split(' ');
            string[] hiddenWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                hiddenWords[i] = GenerateUnderlines(words[i]);
            }

            return string.Join(" ", hiddenWords);
        }
    }
}
