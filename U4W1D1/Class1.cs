using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4W1D1
{
    internal class Atleta
    {
        public string Nome { get; set; }
        public string Sport { get; set; }
        public int Età { get; set; }

        public void MostraDettagli()
        {
            Console.WriteLine($"Atleta: {Nome}, Sport: {Sport}, Età: {Età}");
        }
    }

    class Dipendente
    {
        public string Nome { get; set; }
        public string Ruolo { get; set; }
        public double Stipendio { get; set; }

        public void MostraDettagli()
        {
            Console.WriteLine($"Dipendente: {Nome}, Ruolo: {Ruolo}, Stipendio: {Stipendio}€");
        }
    }

    class Animale
    {
        public string Nome { get; set; }
        public string Specie { get; set; }
        public int Età { get; set; }

        public void EmittiSuono()
        {
            Console.WriteLine($"{Nome} fa un suono caratteristico della sua specie ({Specie}).");
        }
    }
    class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Anno { get; set; }

        public void MostraDettagli()
        {
            Console.WriteLine($"Veicolo: {Marca} {Modello}, Anno: {Anno}");
        }
    }
    class Program
    {
        static void Main()
        {

            Atleta atleta = new Atleta { Nome = "Usain Bolt", Sport = "Atletica", Età = 37 };
            Dipendente dipendente = new Dipendente { Nome = "Mario Rossi", Ruolo = "Sviluppatore", Stipendio = 3500 };
            Animale animale = new Animale { Nome = "Fido", Specie = "Cane", Età = 5 };
            Veicolo veicolo = new Veicolo { Marca = "Tesla", Modello = "Model S", Anno = 2022 };


            atleta.MostraDettagli();
            dipendente.MostraDettagli();
            animale.EmittiSuono();
            veicolo.MostraDettagli();
        }
    }
    }
