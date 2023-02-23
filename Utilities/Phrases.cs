namespace Drinking_Game.Utilities;

public class Phrase
{
    public string Characteristic { get; set; }
    public string StandardPhrase { get; set; }

    public Phrase(string characteristic)
    {
        this.Characteristic = characteristic;
        this.StandardPhrase = $"The {this.Characteristic} in the room";
    }
}

public static class Phrases
{
    private static readonly Random _random = new();
    private static readonly List<Phrase> _phrases = new []
    {
        new Phrase("tallest"),
        new Phrase("shortest"),
        new Phrase("oldest"),
        new Phrase("youngest"),
        new Phrase("most drunk person"),
        new Phrase("least drunk person"),
        new Phrase("funniest"),
        new Phrase("least funny"),
    }.OrderBy(_ => _random.Next()).ToList();

    public static int AmountOfPhrases = _phrases.ToArray().Length;

    /**
     * @returns: stirng - Random phrase/criteria
     */
    public static IEnumerable<Phrase> GetPhrase()
    {
        /*    foreach (string currentPhrase in _phrases) {
            string[] usersMayDecide =
            {
                "funniest",
                    "most drunk person",
                    "least drunk person",
                    "least funny",
            };

            string wordToSearch = currentPhrase.Split(" ")[1];
         /*   if (usersMayDecide.Contains(wordToSearch))
            {
                currentPhrase.Append<>(" - you decide who it is!");
            }
            yield return currentPhrase;*/

        foreach (Phrase phrase in _phrases) yield return phrase;
    }
}