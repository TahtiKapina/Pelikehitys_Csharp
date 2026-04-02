using System.Reflection.Metadata.Ecma335;

namespace Seikkailijanreppu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reppu = new Reppu();

            // Call Lisää repeatedly until the user stops.
            while (true)
            {
                bool added = reppu.Lisää(null); // Lisää shows the menu and creates the chosen item internally
                Console.WriteLine(added ? "Lisäys onnistui." : "Lisäys epäonnistui.");
                Console.WriteLine("Haluatko lisätä toisen? (1 (jatka) / 2 (lopeta))");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                     if (input == 2)
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
        }

        class Nuoli : Tavara
        {
            public Nuoli() : base(0.1f, 0.05f) { }
            public Nuoli(float paino, float tilavuus) : base(paino, tilavuus) { }
        }

        class jousi : Tavara
        {
            public jousi() : base(1f, 4f) { }
            public jousi(float paino, float tilavuus) : base(paino, tilavuus) { }
        }

        class Köysi : Tavara
        {
            public Köysi() : base(1f, 1.5f) { }
            public Köysi(float paino, float tilavuus) : base(paino, tilavuus) { }
        }

        class Vesi : Tavara
        {
            public Vesi() : base(2f, 2f) { }
            public Vesi(float paino, float tilavuus) : base(paino, tilavuus) { }
        }

        class Ruoka_annos : Tavara
        {
            public Ruoka_annos() : base(1f, 0.5f) { }
            public Ruoka_annos(float paino, float tilavuus) : base(paino, tilavuus) { }
        }

        class Miekka : Tavara
        {
            public Miekka() : base(5f, 3f) { }
            public Miekka(float paino, float tilavuus) : base(paino, tilavuus) { }
        }

        class Reppu
        {   
            int Tavaramäärä = 0;
            int Maxtavaramäärä = 5;
            float Paino = 0f;
            float Maxpaino = 10f;
            float Tilavuus = 0f;
            float Maxtilavuus = 15f;
            List<Tavara> Tavarat = new List<Tavara>();
            public bool Lisää(Tavara tavara)
            {
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
                        tavara = new jousi(1f, 4f);
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
