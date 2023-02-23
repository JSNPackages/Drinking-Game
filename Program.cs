using System;
using static DrinkingGame.Card;

namespace DrinkingGame;

class Program
{





    public static void Main(string[] args)
    {
        Card testCard = new Card("Dalgaard", "2 shots");

        Console.WriteLine(testCard.target);
    }





}