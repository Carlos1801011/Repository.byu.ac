using System;


    public class Reference
    {
        private string reference;

        public string GetadiferentReference()
        {
            return reference;
        }
        // It occupies reference on | from the text file
        public void TakeReference(string scripture)
        {
            string[] splitScripture = scripture.Split(" | ");
            reference = splitScripture[0];
        }
    }
