namespace Drinking_Game;

using Utilities;

class Program
{
    public static void Main(string[] args)
    {
        foreach (Phrase phrase in Storage.phrases)
        {
            Console.WriteLine(phrase.StandardPhrase);
        }
    }
}
