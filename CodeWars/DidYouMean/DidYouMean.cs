using System;
using System.Collections.Generic;
using System.Linq;

// BASED ON: https://en.wikipedia.org/wiki/Edit_distance
// finds the word closest to the search word

namespace CodeWars.DidYouMean
{
    public class DidYouMeanClass
    {
        private IEnumerable<string> words;

        public DidYouMeanClass(IEnumerable<string> words)
        {
            this.words = words;
        }

        public string FindMostSimilar(string term)
        {
            List<WordAndDistance> list = new List<WordAndDistance>();
            foreach (var word in words)
            {
                var distance = getDistance(word, term);
                list.Add(new WordAndDistance { Word = word, Distance = distance });
            }

            list = list.OrderBy(w => w.Distance).ToList();
            return list[0].Word;
        }

        private int getDistance(string word, string searchWord)
        {
            var source1Length = word.Length;
            var source2Length = searchWord.Length;

            var matrix = new int[source1Length + 1, source2Length + 1];

            // First calculation, if one entry is empty return full length
            if (source1Length == 0)
                return source2Length;

            if (source2Length == 0)
                return source1Length;

            // Initialization of matrix with row size source1Length and columns size source2Length
            for (var i = 0; i <= source1Length; matrix[i, 0] = i++) { }
            for (var j = 0; j <= source2Length; matrix[0, j] = j++) { }

            // Calculate rows and collumns distances
            for (var i = 1; i <= source1Length; i++)
            {
                for (var j = 1; j <= source2Length; j++)
                {
                    var cost = (searchWord[j - 1] == word[i - 1]) ? 0 : 1;

                    matrix[i, j] = Math.Min(
                        Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1),
                        matrix[i - 1, j - 1] + cost);
                }
            }
            // return result
            return matrix[source1Length, source2Length];
        }

        public class WordAndDistance
        {
            public string Word { get; set; }
            public int Distance { get; set; }
        }
    }
}
