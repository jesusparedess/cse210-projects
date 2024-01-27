using System;

class Program
{
    static void Main()
    {
        var library = new Library();

        library.AddScripture(new Reference("John", 3, 16), "For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life.");
        library.AddScripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to Him, and He will make your paths straight.");
        library.AddScripture(new Reference("Alma", 37, 37), "Counsel with the Lord in all thy doings, and he will direct thee for good, yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep, and when you risest in the morning let thy heart be full of thanks unto God, and if ye do these things, ye shall be lifted up at the last day.");
        library.AddScripture(new Reference("Alma", 36, 6), "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things broought to pass; and small means in many instances doth confound the wise.");


        while (true)
        {
            Scripture currentScripture = library.GetRandomScripture();
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide words, or type 'quit' to stop.");

            while (!currentScripture.IsCompletelyHidden())
            {
                var input = Console.ReadLine();
                if (input?.ToLower() == "quit")
                {
                    return; 
                }

                currentScripture.HideRandomWords(3); 
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());
                Console.WriteLine("\nPress ENTER to hide more words, or type 'quit' to stop.");
            }

            Console.WriteLine("\nYou've hidden the entire scripture. Well done!");
            Console.WriteLine("Press ENTER to try a new scripture, or type 'quit' to stop.");

            var nextInput = Console.ReadLine();
            if (nextInput?.ToLower() == "quit")
            {
                break;
            }
        }
    }
}

// I added a Library class which allows the program to handle multiple scriptures
// and it will choose scriptures at random to present to the user..