using System;
using System.Collections.Generic;

namespace RandomScripture
{
    public class Scripture
    {
        private List<Word> _words;
        private Reference _reference;
        private string _text;
        private int _wordCountMax;
        private int _wordCountTotal;

        public Scripture()
        {
        }

        public Scripture(Reference reference)
        {
            _words = new List<Word>();
            _reference = new Reference(reference.Book, reference.Chapter, reference.Verse, reference.VerseText);
            MakeWordsList(_reference.VerseText);
            _wordCountTotal = 0;
        }

        public void MakeWordsList(string verseText)
        {
            string[] wordArr = verseText.Split(' ');

            _wordCountMax = wordArr.Length - 1;

            foreach (string word in wordArr)
            {
                _words.Add(new Word(word, true));
            }
        }

        public void HideWords()
        {
            List<int> indexes = new List<int>();
            int randNum;
            int[] removedIndexes;

            foreach (var word in _words)
            {
                if (word.IsShown)
                {
                    indexes.Add(_words.IndexOf(word));
                }
            }

            removedIndexes = new int[Math.Min(indexes.Count, 3)];

            Random rand = new Random();

            for (int i = 0; i < removedIndexes.Length; i++)
            {
                randNum = rand.Next(indexes.Count);
                removedIndexes[i] = indexes[randNum];
                indexes.RemoveAt(randNum);
                _wordCountTotal++;
            }

            foreach (int index in removedIndexes)
            {
                _words[index].IsShown = false;
            }
        }

        public string GetRenderedText()
        {
            _text = $"{_reference.Book} {_reference.Chapter} : {_reference.Verse} ";

            foreach (var word in _words)
            {
                if (word.IsShown)
                {
                    _text += word.WordValue + " ";
                }
                else
                {
                    _text += GenerateUnderlines(word.WordValue) + " ";
                }
            }

            return _text;
        }

        public string GenerateUnderlines(string word)
        {
            string underlines = "";

            for (int i = 0; i < word.Length; i++)
            {
                underlines += "_";
            }

            return underlines;
        }

        public bool IsCompletelyHidden()
        {
            int count = 0;

            foreach (var word in _words)
            {
                if (!word.IsShown)
                {
                    count++;
                }
            }

            return count >= _words.Count;
        }
    }
}
