namespace Nuoli_Kauppa
{
    internal class Program
    {
        enum Kärki
        {
            Puu, // 3 kultarahaa
            Teräs, // 5 kultarahaa
            Timantti // 50 kultarahaa
        }

        enum Sulat
        {
            Lehti, // 0 kultarahaa
            kanansulka, // 1 kultaraha
            kotkansulka // 5 kultarahaa
        }

        int pituus;

        class Nuoli
        {
            public Kärki kärki { get; private set; }
            public Sulat sulat { get; private set; }

            public int Pituus
            {
                get { return pituus; }
                set
                {
                    if (value < 60)
                    {
                        pituus = 60;
                    }
                    pituus = value;
                }
            }
            public Nuoli(Kärki kärki, Sulat sulat)
            {
                this.kärki = kärki;
                this.sulat = sulat;
            }

            private int pituus;
            public Kärki GetKärki() { return kärki; }
            public Sulat GetSulat() { return sulat; }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Minkälainen kärki (puu, teräs, timantti)?: ");
            string KärkiInput = Console.ReadLine();
            Nuoli n = new Nuoli(Enum.Parse<Kärki>(KärkiInput, true), Sulat.Lehti);
            Console.WriteLine("Minkälaiset sulat (lehti, kanansulka, kotkansulka)?:");
            string SulatInput = Console.ReadLine();

            Console.WriteLine("Nuolen pituus sentteinä (60-100): ");
            int pituus = Convert.ToInt32(Console.ReadLine());

            Kärki kärki = Enum.Parse<Kärki>(KärkiInput, true);
            Sulat sulat = Enum.Parse<Sulat>(SulatInput, true);

            float Summa = KärkiHinta(kärki) + SulkienHinta(sulat) + PituusHinta(pituus);


            Console.WriteLine($"Tämän nuolen hinta on {Summa} kultarahaa");
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

        static float PituusHinta(int pituus)
        {
            if (pituus < 60 || pituus > 100)
            {
                throw new ArgumentOutOfRangeException("Pituuden tulee olla välillä 60-100 senttimetriä.");
            }
            return pituus * 0.05f;
        }
    }
}
