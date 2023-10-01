using System;


    public class Word
    {
        private string hiddenScripture;
        private List<string> splitWords = new List<string>();
        private int wordsToHide = 5;


        public string GetoccultScripture()
        {
            return hiddenScripture;
        }

        public void StoreHiddenScripture(string scripture)

        {
            string[] splitScripture = scripture.Split(" | ");
            hiddenScripture = splitScripture[1];
        }

        public void HideWords()
        {
            string[] splitWords = hiddenScripture.Split(" ");
            int wordsLeft = 0;

            foreach (string newWord in splitWords)
            {
                if (!newWord.Contains("_"))
                {
                    wordsLeft ++;
                }
            }

            for (int i = 0; i < wordsToHide; i++)
            {
                if (i >= wordsLeft)
                {
                    break;
                }

                Random random = new Random();
                int randomWord ;

                do
                {
                    randomWord = random.Next(0, splitWords.Length);
                } while (splitWords[randomWord].Contains("_"));

                splitWords[randomWord] = new string('_', splitWords[randomWord].Length);
            }
            hiddenScripture = string.Join(" ", splitWords);
        }
    }
