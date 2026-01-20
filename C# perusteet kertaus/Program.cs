namespace C__perusteet_kertaus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int Ritari = 15; // Ritarin terveyspisteet.
            int Örkki = 15; // Örkin terveyspisteet.
            int aikomus;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Olet urhea ritari ja sinut on lähetetty kukistamaan kylää tuhoavan örkin.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Löydät örkin metsästä ja tämä hyökkää sinua kohti. Taistelu alkaa");

            while (Ritari > 0 || Örkki > 0)
            {
                Console.WriteLine("------------------------------------------------------------------");

                Console.WriteLine($"Ritari(Sinä): {Ritari}/15   Örkki: {Örkki}/15");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1 - Hyökkää miekalla");
                Console.WriteLine("2 - Puolustaudu kilvellä");

                Console.Write("Mitä haluat tehdä? ");
                aikomus = Convert.ToInt32(Console.ReadLine());

                static int Vahinkopisteet(int min, int max)
                {
                    Random random = new Random();

                    return random.Next(min, max);
                }

                int Pelaajavahinko = Vahinkopisteet(1, 7);
                int Örkkivahinko = Vahinkopisteet(1, 5);

                if (aikomus == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hyökäsit miekalasi!");
                    Console.WriteLine($"Sivallat örkkiä miekallasi. Teet örkkiin {Pelaajavahinko} pistettä vahinkoa");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Örkki hyökkää sinua kohti nuijallaan!");
                    Console.WriteLine($"Nuija osuu sinuun, tehden {Örkkivahinko} vahinkoa.");
                }
                else
                {
                    int VähenettyVahinko = Örkkivahinko / 2;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nostat kilpesi puolustukseksesi!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Örkki hyökkää sinua kohti nuijallaan!");
                    Console.WriteLine($"Nuija kumahtaa kilpeesi, tehden sinuun vain {VähenettyVahinko} vahinkoa");
                }
            }
        }
    }
}
