using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] stringArray = { "Taco Cat ", "Yo, banana boy ", "Was it a car or a cat I saw " };
        Console.WriteLine("Whatcha got to say?");
        string input = Console.ReadLine();
        foreach (string test in stringArray)
        {
            if (test.Length > stringArray.Length)
            {
                Console.WriteLine(test + input);

            }
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        foreach (string test in stringArray)
        {
            Console.WriteLine(test);
        }
        Console.WriteLine("Press Enter...");
        Console.ReadLine();
        int inf1 = 1;
        int inf2 = 1;
        while (inf1 == inf2)
        {
            Console.WriteLine("INFINITY!");
            inf2++;
            Console.WriteLine("Press Enter");
        }
        Console.ReadLine();
        int var1 = 0;
        int var2 = 5;
        while (var1 < var2)
        {
            var1++;
            Console.WriteLine("Sick!");
        }
        Console.ReadLine();
        int gooble = 0;
        int gobble = 5;
        while (gooble <= gobble)
        {
            gooble++;
            Console.WriteLine(gooble);
        }
        Console.WriteLine("Press Enter...");
        Console.ReadLine();

        List<string> DirectoryList = new List<string>();

        DirectoryList.Add("Ted");
        DirectoryList.Add("Tom");
        DirectoryList.Add("Tim");
        DirectoryList.Add("Tyler");
        DirectoryList.Add("Tadd");

        foreach (string name in DirectoryList)
        {
            Console.WriteLine(name);
        }
        for (int i = 0; i < DirectoryList.Count; i++)
        {
            Console.WriteLine("Write a name from the list above");
            if (DirectoryList.Contains(Console.ReadLine()))
            {
                Console.WriteLine("Confirm Selection");
                Console.WriteLine(DirectoryList.IndexOf(Console.ReadLine()));
                Console.ReadLine();
                break;
            }
            else
            {
                Console.WriteLine("Your selection is not contained in the Directory");
                Console.ReadLine();
            }    
        }
        Console.WriteLine("The Unbound Project Volume 1 - TrackList:");
        List<string> trackList = new List<string>();
        trackList.Add("The Human Element");
        trackList.Add("Social Policy Derelicts");
        trackList.Add("Full Court Press");
        trackList.Add("Degregation");
        trackList.Add("Soul in Flesh");
        trackList.Add("The Human Element");
        foreach (string track in trackList)
        {
            Console.WriteLine(track);
        }
        for (int i = 0; i < trackList.Count; i++)
        {
            Console.WriteLine("Please Select a Track from above");
            if (trackList.Contains(Console.ReadLine()))
            {
                Console.WriteLine("Confirm Selection");
                Console.WriteLine(trackList.IndexOf(Console.ReadLine()));
                Console.ReadLine();
                break;
            }
            else
            {
                Console.WriteLine("Your Selection is not a track");
                Console.ReadLine();
            }    
        }
        List<string> purchaseRecord = new List<string>();
        purchaseRecord.Add("Hank");
        purchaseRecord.Add("Greg");
        purchaseRecord.Add("Simon");
        purchaseRecord.Add("Zander");
        purchaseRecord.Add("Greg");
        var group = purchaseRecord.GroupBy(i => i.ToString());
        foreach( var grp in group )
        {
            if (grp.Count() == 2)
            {
                Console.WriteLine("{0} has appeared {1} times in the list.", grp.Key, grp.Count());
                Console.ReadLine();
            }
        }

    }

}





