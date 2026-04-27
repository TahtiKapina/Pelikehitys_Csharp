namespace Seikkailijanreppu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reppu = new Reppu();

            while (true)
            {
                bool lisätty = reppu.Lisää(null);
                Console.WriteLine(lisätty ? "Lisäys onnistui." : "Lisäys epäonnistui.");
                Console.WriteLine();
                Console.WriteLine(reppu);
                Console.WriteLine();
                Console.WriteLine("Haluatko lisätä toisen? (1 (jatka) / 2 (lopeta))");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    if (input == 2) // jos numero on 2 niin lopettaa ohjelman
                        break;
                }
            }

            Console.WriteLine("Ohjelma lopetetaan.");
        }

        class Tavara
        {
            public float Paino { get; set; }
            public float Tilavuus { get; set; }
            public Tavara(float paino, float tilavuus)
            {
                Paino = paino;
                Tilavuus = tilavuus;
            }

            public override string ToString()
            {
                return "Tavara";
            }
        }

        class Nuoli : Tavara
        {
            public Nuoli() : base(0.1f, 0.05f) { }
            public Nuoli(float paino, float tilavuus) : base(paino, tilavuus) { }

            public override string ToString()
            {
                return "Nuoli";
            }
        }

        class Jousi : Tavara
        {
            public Jousi() : base(1f, 4f) { }
            public Jousi(float paino, float tilavuus) : base(paino, tilavuus) { }

            public override string ToString()
            {
                return "Jousi";
            }
        }

        class Köysi : Tavara
        {
            public Köysi() : base(1f, 1.5f) { }
            public Köysi(float paino, float tilavuus) : base(paino, tilavuus) { }

            public override string ToString()
            {
                return "Köysi";
            }
        }

        class Vesi : Tavara
        {
            public Vesi() : base(2f, 2f) { }
            public Vesi(float paino, float tilavuus) : base(paino, tilavuus) { }

            public override string ToString()
            {
                return "Vesi";
            }
        }

        class Ruoka_annos : Tavara
        {
            public Ruoka_annos() : base(1f, 0.5f) { }
            public Ruoka_annos(float paino, float tilavuus) : base(paino, tilavuus) { }

            public override string ToString()
            {
                return "Ruoka-annos";
            }
        }

        class Miekka : Tavara
        {
            public Miekka() : base(5f, 3f) { }
            public Miekka(float paino, float tilavuus) : base(paino, tilavuus) { }

            public override string ToString()
            {
                return "Miekka";
            }
        }

        class Reppu
        {
            int Tavaramäärä = 0; // tänhetkinen tavaramäärä
            int Maxtavaramäärä = 5; // maksimi tavaramäärä
            float Paino = 0f; // tänhetkinen paino
            float Maxpaino = 10f; // maksimi paino
            float Tilavuus = 0f; // tänhetkinen tilavuus
            float Maxtilavuus = 15f; // maksimi tilavuus
            List<Tavara> Tavarat = new List<Tavara>();

            public override string ToString()
            {
                if (Tavarat.Count == 0)
                {
                    return "Reppu on tyhjä.";
                }

                string sisältö = string.Join(", ", Tavarat);
                return $"Reppun sisällä on seuraavan tavarat: {sisältö}";
            }

            public bool Lisää(Tavara tavara)
            {
                Console.WriteLine($"");

                Console.WriteLine($"Repussa on tällä hetkellä {Tavaramäärä}/{Maxtavaramäärä} tavaraa, {Paino}/{Maxpaino} painoa ja {Tilavuus}/{Maxtilavuus} tilavuus");
                Console.WriteLine("Mitä haluat lisätä?");
                Console.WriteLine("1 - Nuoli");
                Console.WriteLine("2 - Jousi");
                Console.WriteLine("3 - Köysi");
                Console.WriteLine("4 - Vettä");
                Console.WriteLine("5 - Ruokaa");
                Console.WriteLine("6 - Miekka");
                if (!int.TryParse(Console.ReadLine(), out int valinta))
                {
                    Console.WriteLine("Virheellinen syöte. Anna numero väliltä 1-6.");
                    return false;
                }

                switch (valinta)
                {
                    case 1:
                        tavara = new Nuoli(0.1f, 0.05f);
                        break;
                    case 2:
                        tavara = new Jousi(1f, 4f);
                        break;
                    case 3:
                        tavara = new Köysi(1f, 1.5f);
                        break;
                    case 4:
                        tavara = new Vesi(2f, 2f);
                        break;
                    case 5:
                        tavara = new Ruoka_annos(1f, 0.5f);
                        break;
                    case 6:
                        tavara = new Miekka(5f, 3f);
                        break;
                    default:
                        Console.WriteLine("Virheellinen valinta.");
                        return false;
                }

                if (tavara == null) return false;
                if (Tavaramäärä + 1 > Maxtavaramäärä)
                {
                    Console.WriteLine("Reppu on täynnä.");
                    return false;
                }
                if (Paino + tavara.Paino > Maxpaino)
                {
                    Console.WriteLine("Reppu ei kestä enempää painoa.");
                    return false;
                }
                if (Tilavuus + tavara.Tilavuus > Maxtilavuus)
                {
                    Console.WriteLine("Repulla ei ole tarpeeksi tilavuutta.");
                    return false;
                }

                Tavarat.Add(tavara);
                Tavaramäärä++;
                Paino += tavara.Paino;
                Tilavuus += tavara.Tilavuus;
                return true;
            }
        }
    }
}
