namespace Drinking_Game.Utilities;

public class Card {
    // Person to do the dare
    public string target;

    // Dare (e.g. drink up)
    public string dare;

    public Card(string target, string dare)
    {
        this.target = target;
        this.dare = dare;
    }
}