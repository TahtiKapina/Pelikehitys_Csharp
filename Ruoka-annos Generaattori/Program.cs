namespace Ruoka_annos_Generaattori
{
    internal class Program
    {
        enum PaaraakaAine
        {
            Nauta,
            Kana,
            Kasvis
        }

        enum Lisuke
        {
            Peruna,
            Riisi,
            Pasta
        }

        enum Kastike
        {
            Curry,
            Hapanimelä,
            Pippuri,
            Chili
        }

        class Ateria
        {
            public PaaraakaAine PaaraakaAine { get; set; }
            public Lisuke Lisuke { get; set; }
            public Kastike Kastike { get; set; }
        }

        static void Main(string[] args)
        {
            Console.Write("Pääraaka-aine (nautaa, kanaa, kasviksia): ");
            string paaraakaAineInput = Console.ReadLine();

            Console.Write("Lisukeet (perunaa, riisiä, pastaa): ");
            string lisukeInput = Console.ReadLine();

            Console.Write("Kastike (pippuri, chili, tomaatti, curry): ");
            string kastikeInput = Console.ReadLine();

            Enum.TryParse(paaraakaAineInput, true, out PaaraakaAine paaraakaAine);
            Enum.TryParse(lisukeInput, true, out Lisuke lisuke);
            Enum.TryParse(kastikeInput, true, out Kastike kastike);

            Ateria ateria = new Ateria
            {
                PaaraakaAine = paaraakaAine,
                Lisuke = lisuke,
                Kastike = kastike
            };

            

            Console.WriteLine($"{ateria.PaaraakaAine} ja {ateria.Lisuke} ateria {ateria.Kastike}-kastikkeella");
        }
    }
}
