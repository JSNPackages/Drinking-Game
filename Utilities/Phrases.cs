namespace Drinking_Game.Utilities;

public static class Phrases
{
    private static Random _random = new Random();
    private static Func<string, string> TITH = (string characteristic) => $"The {characteristic} in the room";
    private static string[] _phrases = new []
    {
            TITH("tallest"),
            TITH("shortest"),
            TITH("oldest"),
            TITH("youngest"),
            TITH("most drunk person"),
            TITH("least drunk person"),
            TITH("funniest"),
            TITH("most drunk person"),
            TITH("most drunk person"),
            TITH("most drunk person"),
    }.OrderBy<string, int>(x => _random.Next()).ToArray();

    /**
     * @returns: stirng - Random phrase/criteria
     */
    public static IEnumerable<string> GetPhrase()
    {
        string[] toReturn = _phrases.OrderBy(x => _random.Next()).ToArray();

        yield return toReturn;
    }
}