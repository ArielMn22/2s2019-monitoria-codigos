using System;
using Senai.POO.Vingadores.Models;

namespace Senai.POO.Vingadores.Controllers
{
    public class CapitaoAmericaController : HeroisController
    {
        CapitaoAmericaModel cap = new CapitaoAmericaModel(){
            Vida = 1000,
            Equipe = "Vingadores",
            Escudo = "Adamantium",
            CorForeGround = ConsoleColor.Blue
        };

        public void JogarEscudo()
        {
            System.Console.WriteLine("Jogando escudo!");
        }

        public void Defender()
        {
            System.Console.WriteLine("Defendendo com o escudo!");
        }

        public void SetarCor()
        {
            Console.ForegroundColor = cap.CorForeGround;
        }

        public void MostrarInformacoes()
        {
            System.Console.WriteLine("Capitão América");
            System.Console.WriteLine("Vida: " + cap.Vida);
            System.Console.WriteLine("Equipe: " + cap.Equipe);
            System.Console.WriteLine("Cor do text (Foreground): " + cap.CorForeGround);
            System.Console.WriteLine("Escudo: " + cap.Escudo);
        }
    }
}