using System;

    public class Scripture
    {
        private string scripture;

        public string GetNewScripture()
        {
            return scripture;
        }

        // Takes the writings stored in a txt from another file to use them randomly
        public void SelectaNewScripture()
        {
            var scriptures = File.ReadAllLines("scriptu.txt");
            var random = new Random();
            var randomScripture = random.Next(0, scriptures.Length - 1);
            scripture = scriptures[randomScripture];
        }
    }
