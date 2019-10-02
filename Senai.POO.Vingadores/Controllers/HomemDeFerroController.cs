using System;
using Senai.POO.Vingadores.Models;

namespace Senai.POO.Vingadores.Controllers
{
    public class HomemDeFerroController : HeroisController
    {
        HomemDeFerroModel iron = new HomemDeFerroModel() {
            CorForeGround = System.ConsoleColor.Red,
            Vida = 800,
            Equipe = "Vingadores",
            Armadura = "MK 80"
        };

        public void Voar()
        {
            System.Console.WriteLine("Voando!");
        }

        public void Atirar()
        {
            System.Console.WriteLine("Atirando!");
        }

        public void SetarCor()
        {
            Console.ForegroundColor = iron.CorForeGround;
        }

        public void MostrarInformacoes()
        {
            System.Console.WriteLine("Homem de ferro");
            System.Console.WriteLine("Vida: " + iron.Vida);
            System.Console.WriteLine("Equipe: " + iron.Equipe);
            System.Console.WriteLine("Cor do text (Foreground): " + iron.CorForeGround);
            System.Console.WriteLine("Armadura: " + iron.Armadura);
        }

    }
}