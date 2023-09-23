using System;

public class Entry{

    public string _message = "";
    public string _response = "";

    public string _date = DateTime.Now.ToString("dd-MM-yyyy");


public void Display(){
    Console.WriteLine($"The date you saved this document was: {_date} - prompt: {_message}");

    Console.WriteLine(char.ToUpper(_response[0]) + _response.Substring(1));
}

}