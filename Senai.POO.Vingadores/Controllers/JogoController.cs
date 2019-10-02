using System;

namespace Senai.POO.Vingadores.Controllers {
    public class JogoController {
        public void Menu () {
            string escolha = "";
            bool sair = false;

            do {
                Console.ResetColor ();
                Console.Clear ();

                System.Console.WriteLine ("######################################################################");
                System.Console.WriteLine ("                 Vingadores: The Video-Game - Eidos Montreal");
                System.Console.WriteLine ("######################################################################");

                System.Console.WriteLine ("Com qual personagem deseja jogar: ");
                System.Console.WriteLine ("1) Capitão América");
                System.Console.WriteLine ("2) Homem de ferro");
                System.Console.WriteLine ("0) Sair");
                System.Console.WriteLine ("Digite uma opção: ");
                escolha = Console.ReadLine ();

                switch (escolha) {
                    case "1":
                        CapitaoAmericaMenu ();
                        break;

                    case "2":
                        HomemDeFerroMenu ();
                        break;
                    case "0":
                        sair = true;
                        break;
                    default:
                        System.Console.WriteLine ("Insira uma opção válida!");
                        break;
                }
            } while (sair != true);

            Console.Clear ();

            System.Console.WriteLine ("######################################################################");
            System.Console.WriteLine ("                Obrigado por jogar nosso jogo!");
            System.Console.WriteLine ("######################################################################");
            System.Console.WriteLine("Flw!");
        }

        public void CapitaoAmericaMenu () {
            Console.Clear ();

            CapitaoAmericaController cap = new CapitaoAmericaController ();

            cap.SetarCor ();

            ConsoleKeyInfo teclaPressionada;
            bool sair = false;
            do {
                Console.Clear ();

                System.Console.WriteLine ("Qual ação deseja executar:");
                System.Console.WriteLine ("J - Jogar Escudo | D - Defender | P - Pular | S - Sair");
                teclaPressionada = Console.ReadKey ();
                System.Console.WriteLine ();

                switch (teclaPressionada.Key) {
                    case ConsoleKey.J:
                        cap.JogarEscudo ();

                        break;
                    case ConsoleKey.D:
                        cap.Defender ();
                        break;
                    case ConsoleKey.P:
                        cap.Pular ();
                        break;
                    case ConsoleKey.S:
                        sair = true;
                        break;
                    default:
                        System.Console.WriteLine ("Aperte uma tecla válida!");
                        break;
                }

                Pausa ();
            } while (sair != true);
        }
        public void HomemDeFerroMenu () {
            Console.Clear ();

            HomemDeFerroController iron = new HomemDeFerroController ();

            iron.SetarCor ();

            ConsoleKeyInfo teclaPressionada;
            bool sair = false;
            do {
                Console.Clear ();

                System.Console.WriteLine ("Qual ação deseja executar:");
                System.Console.WriteLine ("A - Atirar | V - Voar | P - Pular | S - Sair");
                teclaPressionada = Console.ReadKey ();
                System.Console.WriteLine ();

                switch (teclaPressionada.Key) {
                    case ConsoleKey.V:
                        iron.Voar ();

                        break;
                    case ConsoleKey.A:
                        iron.Atirar ();
                        break;
                    case ConsoleKey.P:
                        iron.Pular ();
                        break;
                    case ConsoleKey.S:
                        sair = true;
                        break;
                    default:
                        System.Console.WriteLine ("Aperte uma tecla válida!");
                        break;
                }

                Pausa ();
            } while (sair != true);
        }

        public void Pausa () {
            System.Console.WriteLine ("Aperte uma tecla para continuar...");
            Console.ReadKey ();
        }
    }
}