namespace Drinking_Game.Utilities;

public class LoggingUtils {
  public static void PrintCard(Card card)
  {
      int iterations = 8;

      Console.Write("╔");
       for (int i = 0; i < iterations; i++)
       {
           // make loop
           Console.Write("═");
           // end loop

           Console.WriteLine("╗");
           
       }
      //        ╔════════════════════╗
        //      ║                    ║
        //      ║                    ║
        //      ║                    ║
        //      ║                    ║
        //      ║                    ║
        //      ║                    ║
        //      ║                    ║
        //      ║                    ║
        //      ║                    ║
        //      ║                    ║
      //        ╚════════════════════╝


  }
}