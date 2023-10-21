using System;

class Program
{
    //The program takes a YouTube video and gives it the YouTube name and title and includes comments from random people.
    static void Main(string[] args)
    {
        Video[] _videosLocal = new Video[4];
        //name, tittle and time
        _videsLocal[0] = new Video("Mr.Beast", "The most skilled workers in the world!", 150);
        //Comments
        _videosLocal[0].AddCommentNew("@GenedarTv", "I have a strong urge to give him tons of money");
        _videosLocal[0].AddCommentNew("@Morimori", "Chris and Jimmy are the best comedy duo And the editor makes it funnier with the edits lol.");
        _videosLocal[0].AddCommentNew("@lilith", "I really appreciate the things you do for others and our planet");

        _videosLocal[1] = new Video("Mr hacking", "HOW MANY HOURS SHOULD BE DEDICATED TO HACKING?", 980);
        _videosLocal[1].AddCommentNew("@Hackboy", "That is interesting!");
        _videosLocal[1].AddCommentNew("@Troll me ", "this guy doesn't know how to play!!!!");
        _videosLocal[1].AddCommentNew("@carcar", "Good explanation at minute 2:30.");
        
        _videosLocal[2] = new Video("Unrtec", "How to Install Goland on a Windows Computer | Tutorial", 750);
        _videosLocal[2].AddCommentNew("@prohacking124", "I can't get step three to work. HELP MEE");
        _videosLocal[2].AddCommentNew("@abastki", "I think we should explain virtualization better!");
        _videosLocal[2].AddCommentNew("@panasoo", "Finally someone who makes my visual studio code work Thanks bro");

        _videosLocal[3] = new Video("CryptoNews", "I downloaded the 7 most dangerous computer viruses How to fix?", 480);
        _videosLocal[3].AddCommentNew("@Retribuited", "I'll be honest, Pankoza is probably my favorite Virus Coder so far in the series, I am quite invested into this");
        _videosLocal[3].AddCommentNew("@mooon1155", "you have the biggest bravery of any computer professional, your bravery to show us the viruses that are harmful and those that aren't. i am very proud to say that you are helping us gamers!");
        _videosLocal[3].AddCommentNew("@Whatif", "imagine if a virus is powerful enough to enable wifi and try to spread to other devices on your network at the same time");
        //Range for the display
        for(int i = 0; i < _videosLocal.Length ; i++)
        {
            Console.WriteLine();
            _videosLocal[i].DisplayVideoInfo();
            _videosLocal[i].DisplayVideoComments();
        }
    }
}