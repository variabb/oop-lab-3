using GameAccountNamesspace;
using GameNamespace;
using Factory;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо облікові записи гравців
            var standardAccount = new StandardAccount("StandardPlayer");
            var doubleLossAccount = new DoubleLossAccount("DoubleLossPlayer");
            var winningStreakAccount = new WinningStreakAccount("WinningStreakPlayer");

            var gameFactory = new GameFactory();
            
            // Імітація ігор
            PlayGame(standardAccount, doubleLossAccount, gameFactory.CreateGame(GameType.Standard, "john", 10));
            PlayGame(standardAccount, doubleLossAccount, gameFactory.CreateGame(GameType.Standard, "john", 15));
            PlayGame(standardAccount, doubleLossAccount, gameFactory.CreateGame(GameType.Standard, "john", 20));
            PlayGame(doubleLossAccount, winningStreakAccount, gameFactory.CreateGame(GameType.Training, "mango"));
            PlayGame(winningStreakAccount, standardAccount, gameFactory.CreateGame(GameType.OneSide, "Varia", 10));
            
            // Виведення статистики гравців
            standardAccount.GetStats();
            doubleLossAccount.GetStats();
            winningStreakAccount.GetStats();
        }

        static void PlayGame(GameAccount player1, GameAccount player2, BaseGame game)
        {
            Random rand = new Random();
            bool playerWins = rand.NextDouble() > 0.5;

            if (playerWins)
            {
                player1.WinGame(game);
                player2.LoseGame(game);
            }
            else
            {
                player1.LoseGame(game);
                player2.WinGame(game);
            }
        }
    }
}
