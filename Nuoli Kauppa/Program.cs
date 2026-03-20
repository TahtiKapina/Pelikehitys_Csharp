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

            public static Nuoli EliittiNuoli()
            {
                return new Nuoli(Kärki.Timantti, Sulat.kotkansulka) { Pituus = 100 };
            }

            public static Nuoli Aloitelijanuoli()
            {
                return new Nuoli(Kärki.Puu, Sulat.kanansulka) { Pituus = 70 };
            }

            public static Nuoli Perusnuoli()
            {
                return new Nuoli(Kärki.Teräs, Sulat.kanansulka) { Pituus = 85 };
            }

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
            Console.WriteLine("Tervetuloa nuolikauppaan.");
            Console.WriteLine("Haluatko: ");
            Console.WriteLine("1. Teettää nuolen tilaustyönä?");
            Console.WriteLine("2. Ostaa valmiin nuolen?");
            Console.WriteLine("Valinta: ");
            Console.WriteLine("");
            string Valinta = Console.ReadLine();

            if (Valinta == "1")
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

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Valitse valmis nuoli: ");
                Console.WriteLine("1. Eliittinuoli");
                Console.WriteLine("2. Aloittelijaanuoli");
                Console.WriteLine("3. Perusnuoli");
                string NuoliValinta = Console.ReadLine();

                if (NuoliValinta == "1")
                {
                    Nuoli n = Nuoli.EliittiNuoli();
                    float Summa = KärkiHinta(n.GetKärki()) + SulkienHinta(n.GetSulat()) + PituusHinta(n.Pituus);
                    Console.WriteLine($"Tämän nuolen hinta on {Summa} kultarahaa");
                }
                else if (NuoliValinta == "2")
                {
                    Nuoli n = Nuoli.Aloitelijanuoli();
                    float Summa = KärkiHinta(n.GetKärki()) + SulkienHinta(n.GetSulat()) + PituusHinta(n.Pituus);
                    Console.WriteLine($"Tämän nuolen hinta on {Summa} kultarahaa");
                }
                else if (NuoliValinta == "3")
                {
                    Nuoli n = Nuoli.Perusnuoli();
                    float Summa = KärkiHinta(n.GetKärki()) + SulkienHinta(n.GetSulat()) + PituusHinta(n.Pituus);
                    Console.WriteLine($"Tämän nuolen hinta on {Summa} kultarahaa");
                }
                else
                {
                    Console.WriteLine("Virheellinen valinta.");
                }


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
}
