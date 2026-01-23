using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SnakeandLadder
{
    internal class SnakeandLadder
    {
        class Player
        {
            public string Name { get; set; }
            public int Position { get; set; }

            public Player(string name)
            {
                Name = name;
                Position = 0;
            }
        }

        enum GameOption
        {
            NoPlay = 0,
            Ladder = 1,
            Snake = 2
        }

        class Game
        {
            private Random random = new Random();
            private int diceRollCount = 0;
            private const int WINNING_POSITION = 100;

            public int RollDice()
            {
                int diceValue = random.Next(1, 7);
                Console.WriteLine($"🎲 Dice rolled: {diceValue}");
                return diceValue;
            }

            public GameOption CheckOption()
            {
                int option = random.Next(0, 3);
                return (GameOption)option;
            }

            public GameOption PlayTurnAndReturnOption(Player player)
            {
                int diceValue = RollDice();
                GameOption option = CheckOption();
                int previousPosition = player.Position;

                Console.WriteLine($"Encountered: {option}");

                switch (option)
                {
                    case GameOption.NoPlay:
                        Console.WriteLine($"No Play - {player.Name} stays at {player.Position}");
                        break;

                    case GameOption.Ladder:
                        player.Position += diceValue;
                        Console.WriteLine($"🪜 Ladder! Moving forward by {diceValue}");
                        break;

                    case GameOption.Snake:
                        player.Position -= diceValue;
                        Console.WriteLine($"🐍 Snake! Moving backward by {diceValue}");
                        break;
                }

                // Handle position below 0
                if (player.Position < 0)
                {
                    player.Position = 0;
                    Console.WriteLine($"Went below 0. Restarting from 0");
                }

                // Handle position above 100
                if (player.Position > WINNING_POSITION)
                {
                    Console.WriteLine($"Would exceed 100. Staying at {previousPosition}");
                    player.Position = previousPosition;
                }

                Console.WriteLine($"✅ {player.Name} is at position: {player.Position}\n");
                return option;
            }

            // Single Player Mode
            public void PlaySinglePlayerGame(Player player)
            {
                Console.WriteLine($"\n=== Single Player Mode: {player.Name} ===\n");
                diceRollCount = 0;

                while (player.Position != WINNING_POSITION)
                {
                    diceRollCount++;
                    Console.WriteLine($"--- Roll #{diceRollCount} ---");
                    PlayTurnAndReturnOption(player);
                }

                Console.WriteLine($"\n🎉 {player.Name} WON in {diceRollCount} rolls! 🎉\n");
            }

            // Two Player Mode
            public void PlayTwoPlayerGame(Player player1, Player player2)
            {
                Player currentPlayer = player1;
                Player otherPlayer = player2;
                diceRollCount = 0;

                Console.WriteLine($"\n=== Two Player Mode: {player1.Name} vs {player2.Name} ===\n");

                while (player1.Position != WINNING_POSITION && player2.Position != WINNING_POSITION)
                {
                    diceRollCount++;
                    Console.WriteLine($"--- Roll #{diceRollCount} - {currentPlayer.Name}'s turn ---");

                    GameOption option = PlayTurnAndReturnOption(currentPlayer);

                    // Extra turn on ladder
                    if (option == GameOption.Ladder && currentPlayer.Position != WINNING_POSITION)
                    {
                        Console.WriteLine($"🪜 {currentPlayer.Name} gets another turn!\n");
                        continue;
                    }

                    // Switch players
                    Player temp = currentPlayer;
                    currentPlayer = otherPlayer;
                    otherPlayer = temp;
                }

                Player winner = player1.Position == WINNING_POSITION ? player1 : player2;
                Console.WriteLine($"\n🎉🎉 {winner.Name} WINS in {diceRollCount} total rolls! 🎉🎉\n");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Test Single Player
                Player player1 = new Player("Saitama");
                Game game = new Game();
                game.PlaySinglePlayerGame(player1);

                // Test Two Player
                Player player2 = new Player("Genos");
                Player player3 = new Player("Tatsumaki");
                Game game2 = new Game();
                game2.PlayTwoPlayerGame(player2, player3);

                Console.ReadLine();
            }
        }
    }

}

