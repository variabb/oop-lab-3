using GameAccountNamesspace;
using GameNamespace;
using Factory;
using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо екземпляр DbContext (імітуємо базу даних)
            var context = new DbContext();

            // Створюємо репозиторії для акаунтів та ігор
            var accountRepository = new AccountRepository(context);
            var gameRepository = new GameRepository(context);

            // Створюємо фабрику для створення ігор
            var gameFactory = new GameFactory(gameRepository);

            // Створюємо кілька акаунтів
            var standardAccount = new StandardAccount(4, "Player4");
            var doubleLossAccount = new DoubleLossAccount(5, "Player5");
            var winningStreakAccount = new WinningStreakAccount(6, "Player6");

            // Додаємо акаунти в базу даних
            accountRepository.CreateAccount(standardAccount);
            accountRepository.CreateAccount(doubleLossAccount);
            accountRepository.CreateAccount(winningStreakAccount);

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
