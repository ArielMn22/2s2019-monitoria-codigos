using System;
using Senai.POO.Vingadores.Controllers;

namespace Senai.POO.Vingadores {
    class Program {
        static void Main (string[] args) {
            JogoController game = new JogoController();

            game.Menu();            
        }
    }
}