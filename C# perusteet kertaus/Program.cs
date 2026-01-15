namespace C__perusteet_kertaus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ritari = 15; // Ritarin terveyspisteet.
            int Örkki = 15; // Örkin terveyspisteet.

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Olet urhea ritari ja sinut on lähetetty kukistamaan kylää tuhoavan örkin.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Löydät örkin metsästä ja tämä hyökkää sinua kohti. Taistelu alkaa");

            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine($"Ritari(Sinä): {Ritari}/15   Örkki: {Örkki}/15");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1 - Hyökkää miekalla");
            Console.WriteLine("2 - Puolustaudu kilvellä");

            Console.Write("Mitä haluat tehdä? ");
        }
    }
}
