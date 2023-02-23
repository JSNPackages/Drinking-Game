using Drinking_Game.Utilities;

namespace Drinking_Game;

class Program
{
    public static void Main(string[] args)
    {
        Card testCard = new Card("Dalgaard", "2 shots");
        for (int i = 0; i  < Phrases.AmountOfPhrases; i++)
        {
            Phrases.GetPhrase();
        }
    }
}