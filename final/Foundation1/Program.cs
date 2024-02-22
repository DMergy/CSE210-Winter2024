using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Videos> videosList = new List<Videos>();
    

    Videos video1 = new Videos("Mark Ruffalo Suffers For His Art While Eating Spicy Wings", "Hot Ones", 975);

    Comments video1Comment1 = new Comments("Jamie", "Something I love about Hot Ones is hearing the crew laugh from behind the scenes, makes the whole thing feel more genuine.");
    Comments video1Comment2 = new Comments("Pilot", "This is genuinely one of the best episodes. You can tell Mark Ruffalo WANTS to be there, and those are the episodes I end up loving.");
    Comments video1Comment3 = new Comments("Tough", "Mark is so great. He seems like a regular guy who happens to be a famous actor.  Not many famous actors can pull that off.");

    video1.ListComments(video1Comment1);
    video1.ListComments(video1Comment2);
    video1.ListComments(video1Comment3);

    videosList.Add(video1);

    Videos video2 = new Videos("His secret beach house is inside a box truck!?", "Tiny House Giant Journey", 975);

    Comments video2Comment1 = new Comments("Vic", "OMG! This is the best designed rig I've seen in YEARS. Kudos to you, Sir.");
    Comments video2Comment2 = new Comments("Diva", "Dude is a renaissance man.  Excellent craftsmanship and he is a grandpa that surfs, how cool is that?  Kudos to this guy!");
    Comments video2Comment3 = new Comments("James", "Man, this is by far the best set up I've ever seen. And to have never been plugged in, WOW!");

    video2.ListComments(video2Comment1);
    video2.ListComments(video2Comment2);
    video2.ListComments(video2Comment3);

    videosList.Add(video2);

    Videos video3 = new Videos("Sonic vs. Wienerschnitzel Taste Test, FOOD FEUDS", "Good Mythical Morning", 975);

    Comments video3Comment1 = new Comments("Sultan", "Ah, yet another moment for the Rhett and Link being best friends for 10mins compilations.");
    Comments video3Comment2 = new Comments("Nova", "We need to have a triple header of the Costco food court vs the Sam's Club food court vs the BJ's food court.");
    Comments video3Comment3 = new Comments("Jenn", "I would love to see one of these food joints sponsor an episode.");

    video3.ListComments(video3Comment1);
    video3.ListComments(video3Comment2);
    video3.ListComments(video3Comment3);

    videosList.Add(video3);

    foreach (Videos videos in videosList)
        {
            videos.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }

    }

}