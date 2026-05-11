namespace Robooti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robotti robotti = new Robotti();
            
            for(int i=0; i < robotti.Käskyt.Length; i++)
            {
                Console.Write("Mitä komentoja syötetään robotille? Vaihtoehdot: Käynnistä, Sammuta, Ylös, Alas, Oikea, Vasen. ");
                string syote = Console.ReadLine();

                switch (syote)
                {
                    case "Käynnistä":   
                        robotti.Käskyt[i] = new Käynistä();
                        break;
                    case "Sammuta":
                        robotti.Käskyt[i] = new Lopeta();
                        break;
                    case "Ylös":
                        robotti.Käskyt[i] = new YlösKäsky();
                        break;
                    case "Alas":
                        robotti.Käskyt[i] = new AlasKäsky();
                        break;
                    case "Oikea":
                        robotti.Käskyt[i] = new OikeaKäsky();
                        break;
                    case "Vasen":
                        robotti.Käskyt[i] = new VasenKäsky();
                        break;
                    default:
                        robotti.Käskyt[i] = null;
                        break;
                } 
            }

            Console.WriteLine();
            robotti.Suorita();
        }

        public class Robotti
        {
            public int X { get; set; }
            public int Y { get; set; }
            public bool OnKäynnissä { get; set; }
            public IRobottiKäsky?[] Käskyt { get; } = new IRobottiKäsky?[3];

            public void Suorita()
            {
                foreach (IRobottiKäsky? käsky in Käskyt)
                {
                    käsky?.Suorita(this);
                    Console.WriteLine($"[{X} {Y} {OnKäynnissä}]");
                }
            }
        }

        public interface IRobottiKäsky
        {
            void Suorita(Robotti robotti);
        }

        public class Käynistä : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                robotti.OnKäynnissä = true;
            }
        }

        public class Lopeta : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                robotti.OnKäynnissä = false;
            }
        }

        public class YlösKäsky : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    robotti.Y++;
                }
            }
        }

        public class AlasKäsky : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    robotti.Y--;
                }
            }
        }

        public class VasenKäsky : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    robotti.X--;
                }
            }
        }

        public class OikeaKäsky : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    robotti.X++;
                }
            }
        }
    }
}
