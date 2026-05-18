using System.Runtime.CompilerServices;

namespace Ruudukko_koordinaatisto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koordinaatti Keski = new Koordinaatti(0, 0);

            Koordinaatti[] testiPisteet = new Koordinaatti[]
            {
                new Koordinaatti(-1, -1),
                new Koordinaatti(-1, 0),
                new Koordinaatti(-5, 1),
                new Koordinaatti(0, -12),
                new Koordinaatti(0, 0),
                new Koordinaatti(0, 1),
                new Koordinaatti(1, -1),
                new Koordinaatti(2, 0),
                new Koordinaatti(1, 1),
                new Koordinaatti(5, -5)
            };

            foreach (Koordinaatti piste in testiPisteet)
            {
                if (Keski.x == piste.x && Keski.y == piste.y)
                {
                    Console.WriteLine("Annettu kooedinaatti 0,0 on koordinaattissa 0,0");
                }
                else if (Keski.OnkoVieressä(piste))
                {
                    Console.WriteLine($"Annettu kooedinaatti {piste.x},{piste.y} on koordinaatin 0,0 vieressä");
                }
                else
                {
                    Console.WriteLine($"Annettu kooedinaatti {piste.x},{piste.y} ei ole koordinaatin 0,0 vieressä");
                }
            }
        }

        public struct Koordinaatti
        {
            public int x { get; private set; }
            public int y { get; private set; }

            public Koordinaatti(int X, int Y)
            {
                x = X;
                y = Y;
            }

            public bool OnkoVieressä(Koordinaatti toinen)
            {
                if (this.x == toinen.x && this.y == toinen.y)
                {
                    return false;
                }

                if (this.x == toinen.x && (this.y == toinen.y + 1 || this.y == toinen.y - 1))
                {
                    return true;
                }
                else if (this.y == toinen.y && (this.x == toinen.x + 1 || this.x == toinen.x - 1))
                {
                    return true;
                }
                else if (this.x == toinen.x + 1 && (this.y == toinen.y + 1 || this.y == toinen.y - 1))
                {
                    return true;
                }
                else if (this.x == toinen.x - 1 && (this.y == toinen.y + 1 || this.y == toinen.y - 1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
