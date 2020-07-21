using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Defuse The Bomb!");
        Console.WriteLine("Select a wire to cut");
        Console.WriteLine("1=red, 2=green, 3=blue");
        string guess = Console.ReadLine();
        bool attemptFail = false;
        bool gameWin = false;
        //while (attemptCurrent == true)
        do
        {
            switch (guess)
            {
                case "1":
                case "red":
                    attemptFail = true;
                    break;
                case "2":
                case "green":
                    gameWin = true;
                    break;
                case "3":
                case "blue":
                    attemptFail = true;
                    break;
            }
        }
        while (attemptFail == false && gameWin == false);

        while (attemptFail == true)
        {
            Console.WriteLine("Wrong Wire. BOOM! Sorry, you lose");
            Console.ReadLine();
            break;
        }

        while (gameWin == true)
        {
            Console.WriteLine("You defused the bomb! You're the hero we need!");
            Console.ReadLine();
            break;
        }

    }
}
