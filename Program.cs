using Drinking_Game.Utilities;

namespace Drinking_Game;

class Program
{
    public static void Main(string[] args)
    {
        Card testCard = new Card("Dalgaard", "2 shots");

        Console.WriteLine(testCard.target);
    }
}