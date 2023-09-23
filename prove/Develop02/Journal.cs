using System;
using System.Collections.Generic;

public class Journal{

    public string _names = "";

    public List<Entry> _Newentries = new List<Entry>();

    public void Display(){

        Console.WriteLine($"Name: " +char.ToUpper(_names[0]) +_names.Substring(1));

        Console.WriteLine($"Your Entries: ");

        foreach (Entry elementEntryNews in _Newentries)
        {

            elementEntryNews.Display();
        }

    }
}