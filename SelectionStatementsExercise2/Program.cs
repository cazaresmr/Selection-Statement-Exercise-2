using System;
namespace SelectionStatementsExercise2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your favorite school subject?");

            string favoriteSubject = (Console.ReadLine() ?? string.Empty).ToString().ToLower();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math: Numbers and equations are the foundation of the universe!");
                    break;
                case "science":
                    Console.WriteLine("Science: Exploring the wonders of the natural world!");
                    break;
                case "history":
                    Console.WriteLine("History: Learning from the past to build a better future!");
                    break;
                case "english":
                    Console.WriteLine("English: The beauty of language and literature!");
                    break;
                case "art":
                    Console.WriteLine("Art: Expressing creativity through various mediums!");
                    break;
                default:
                    if (string.IsNullOrWhiteSpace(favoriteSubject))
                    {
                        Console.WriteLine("You didn't enter anything. Please provide a valid subject.");
                    }
                    else
                    {
                        Console.WriteLine("That's an interesting subject! Every field of study has its own unique beauty.");
                    }
                    break;
            }
        }
    }
}
