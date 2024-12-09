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
                case GameType.Standard: return new StandardGame(rating, opponentName);
                case GameType.Training: return new TrainingGame(opponentName);
                case GameType.OneSide: return new OneSideGame(opponentName, rating);
                default: throw new ArgumentException("Неправильний тип гри");
            }
        }
    }
}
