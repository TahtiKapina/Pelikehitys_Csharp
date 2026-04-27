namespace Ovi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Ovi
    {
       enum OviTila { Auki, Kiinni, Lukittu, Lopeta }

        static void OviAuki(ref OviTila Ovi)
        {
            Console.Write("Ovi On auki. Mitä haluat tehdä? ");
            string aikomus = Console.ReadLine() ?? "";

            if (aikomus == "Avaa")
            {
                Console.WriteLine("Ovi on jo auki");
            }

            else if (aikomus == "Sulje")
            {
                Console.WriteLine("Laitoit oven kiinni");

                Ovi = OviTila.Kiinni;
            }

            else if (aikomus == "Lukitse")
            {
                Console.WriteLine("Ovi pitää ensin sulkea ennen kun pystyy lukitsemaan");
            }

            else if (aikomus == "Lopeta")
            {
                Console.WriteLine("Lopetetaan");

                Ovi = OviTila.Lopeta;
            }
        }

        static void OviKiini(ref OviTila Ovi)
        {
            Console.Write("Ovi On kiinni. Mitä haluat tehdä? ");
            string aikomus = Console.ReadLine() ?? "";

            if (aikomus == "Avaa")
            {
                Console.WriteLine("Avasit oven");

                Ovi = OviTila.Auki;
            }

            else if (aikomus == "Sulje")
            {
                Console.WriteLine("Ovi on jo kiinni");
            }

            else if (aikomus == "Lukitse")
            {
                Console.WriteLine("Lukitsit oven");

                Ovi = OviTila.Lukittu;
            }

            else if (aikomus == "Lopeta")
            {
                Console.WriteLine("Lopetetaan");

                Ovi = OviTila.Lopeta;
            }
        }

        static void OviLukittu(ref OviTila Ovi)
        {
            Console.Write("Ovi On Lukittu. Mitä haluat tehdä? ");
            string aikomus = Console.ReadLine() ?? "";

            if (aikomus == "Avaa")
            {
                Console.WriteLine("Lukitus pitäisi ottaa pois ensin");
            }

            else if (aikomus == "Sulje")
            {
                Console.WriteLine("Lukitus pitäisi ottaa pois ensin");
            }

            else if (aikomus == "Lukitse")
            {
                Console.WriteLine("Ovi on jo lukossa");
            }

            else if (aikomus == "Avaa lukko")
            {
                Console.WriteLine("Lukko on avattu");

                Ovi = OviTila.Kiinni;
            }

            else if (aikomus == "Lopeta")
            {
                Console.WriteLine("Lopetetaan");

                Ovi = OviTila.Lopeta;
            }
        }
    }
}
