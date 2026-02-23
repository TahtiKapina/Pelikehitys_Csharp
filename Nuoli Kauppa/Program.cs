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

        class Nuoli
        {
            public Kärki Kärki { get; set; }
            public Sulat Sulat { get; set; }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
