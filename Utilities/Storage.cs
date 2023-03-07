using Drinking_Game.Utilities;

namespace Drinking_Game.Utilities;

public static class Storage {
    public static List<Phrase> phrases = new();

    static Storage()
    {
        Phrases.PopulateList(phrases);
    }

    /**
     * @returns List of cards
     *
    public static Card[] GetCards()
    {

    }*/
}