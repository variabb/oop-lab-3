using GameNamespace;
using GameAccountNamesspace;
namespace Factory
{ 
    enum GameType
    {
        Standard,
        Training,
        OneSide
    }

    class GameFactory
    {
        public BaseGame CreateGame(GameType gameType, string opponentName, int rating = 0)
        {
            switch (gameType)
            {
                case GameType.Standard: return new StandardGame(1, rating, opponentName);
                case GameType.Training: return new TrainingGame(2, opponentName);
                case GameType.OneSide: return new OneSideGame(3, opponentName, rating);
                default: throw new ArgumentException("Неправильний тип гри");
            }
        }
    }
}
