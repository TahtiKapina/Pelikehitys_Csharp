namespace Nuoli_Kauppa
{
    internal class Program
    {
        enum Kärki
        {
            Puu,
            Teräs,
            Timantti
        }

        enum Sulat
        {
            Lehti,
            kanansulka,
            kotkansulka
        }

        int pituus;

        class Nuoli
        {
            public Kärki Kärki { get; set; }
            public Sulat Sulat { get; set; }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Minkälainen kärki (puu, teräs, timantti)?: ");
            string KärkiInput = Console.ReadLine();

            Console.WriteLine("Minkälaiset sulat (lehti, kanansulka, kotkansulka)?:");
            string SulatInput = Console.ReadLine();

            Console.WriteLine("Nuolen pituus sentteinä (60-100): ");
            int pituus = Convert.ToInt32(Console.ReadLine);

            int Summa = 0;

            Console.WriteLine($"Tämän nuolen hinta on // Täydenettävää // kultarahaa");
        }

        static int KärkiHinta(Kärki kärki)
        {
            switch (kärki)
            {
                case Kärki.Puu:
                    return 3;
                case Kärki.Teräs:
                    return 5;
                case Kärki.Timantti:
                    return 50;
                default:
                    return 0;
            }
        }

        static int SulkienHinta(Sulat sulat)
        {
            switch (sulat)
            {
                case Sulat.Lehti:
                    return 0;
                case Sulat.kanansulka:
                    return 1;
                case Sulat.kotkansulka:
                    return 5;
                default:
                    return 0;
            }
        }

        static double PituusHinta(int pituus)
        {
            if (pituus < 60 || pituus > 100)
            {
                throw new ArgumentOutOfRangeException("Pituuden tulee olla välillä 60-100 senttimetriä.");
            }
            return pituus * 0.05;
        }
    }
}
