using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Defuse The Bomb!");
        Console.WriteLine("Select a wire to cut");
        Console.WriteLine("1=red, 2=green, 3=blue");
        string guess = Console.ReadLine();
        bool gameWin = guess == "green";
        
        do
        {
            switch (guess)
            {
                case "1":
                case "red":
                    Console.WriteLine("Wrong Wire. There is still time left! Try again!");
                    Console.WriteLine("1=red, 2=green, 3=blue");
                    guess = Console.ReadLine();
                    break;
                case "2":
                case "green":
                    Console.WriteLine("You defused the bomb! You're the hero we need!");
                    gameWin = true;
                    break;
                case "3":
                case "blue":
                    Console.WriteLine("Wrong Wire. There is still time left! Try again!");
                    Console.WriteLine("1=red, 2=green, 3=blue");
                    guess = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Your choice doesn't make sense.");
                    Console.WriteLine("1=red, 2=green, 3=blue");
                    guess = Console.ReadLine();
                    break;
            }
 
        }
        while (!gameWin);


        while (gameWin == true)
        {
            Console.WriteLine("Please Select Your Reward...");
            Console.WriteLine("1=money, 2=fame, 3=karma");
            string reward = Console.ReadLine();
            bool end = reward == "karma";
            while (!end)
            {
                switch (reward)
                {
                    case "1":
                    case "money":
                        Console.WriteLine("You are rewarded with endless riches, but you rethink your choice...");
                        Console.WriteLine("Please Select Your Reward...");
                        Console.WriteLine("1=money, 2=fame, 3=karma");
                        reward = Console.ReadLine();
                        break;
                    case "2":
                    case "fame":
                        Console.WriteLine("You become known all over the Earth for your good deeds, but you rethink your choice...");
                        Console.WriteLine("Please Select Your Reward...");
                        Console.WriteLine("1=money, 2=fame, 3=karma");
                        reward = Console.ReadLine();
                        break;
                    case "3":
                    case "karma":
                        Console.WriteLine("Your good deeds are reflected back onto you through the quantum realm");
                        Console.ReadLine();
                        end = true;
                        break;
                    default:
                        Console.WriteLine("Your choice doen't make sense");
                        Console.WriteLine("1=money, 2=fame, 3=karma");
                        reward = Console.ReadLine();
                        break;
                }
                if (end == true)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
