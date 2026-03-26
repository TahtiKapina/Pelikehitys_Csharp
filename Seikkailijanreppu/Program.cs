namespace Seikkailijanreppu
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
            public Nuoli(float paino, float tilavuus) : base(paino, tilavuus)
            {
                float Paino = 0.1f;
                float Tilavuus = 0.05f;
            }
        }

        class jousi : Tavara
        {
            public jousi(float paino, float tilavuus) : base(paino, tilavuus)
            {
                float Paino = 1f;
                float Tilavuus = 4f;
            }
        }

        class Köysi : Tavara
        {
            public Köysi(float paino, float tilavuus) : base(paino, tilavuus)
            {
                float Paino = 1f;
                float Tilavuus = 1.5f;
            }
        }

        class Vesi : Tavara
        {
            public Vesi(float paino, float tilavuus) : base(paino, tilavuus)
            {
                float Paino = 2f;
                float Tilavuus = 2f;
            }
        }

        class Ruoka_annos : Tavara
        {
            public Ruoka_annos(float paino, float tilavuus) : base(paino, tilavuus)
            {
                float Paino = 1f;
                float Tilavuus = 0.5f;
            }
        }

        class Miekka : Tavara
        {
            public Miekka(float paino, float tilavuus) : base(paino, tilavuus)
            {
                float Paino = 5f;
                float Tilavuus = 3f;
            }
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
                Console.WriteLine($"Repussa on tällä hetkellä {Tavaramäärä}/10 tavaraa, {Paino}/30 painoa ja {Tilavuus}/20 tilavuus");
                Console.WriteLine("Mitä haluat lisätä?");
                Console.WriteLine("1 - Nuoli");
                Console.WriteLine("2 - Jousi");
                Console.WriteLine("3 - Köysi");
                Console.WriteLine("4 - Vettä");
                Console.WriteLine("5 - Ruokaa");
                Console.WriteLine("6 - Miekka");
                int valinta = int.Parse(Console.ReadLine());

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
            }
        }
    }
}
