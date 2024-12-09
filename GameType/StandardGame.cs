using GameNamespace;

namespace GameNamespace
{
    public class StandardGame : BaseGame
    {
        public StandardGame(int rating, string opponentName)
            : base(opponentName, rating) // Передаємо rating до конструктора BaseGame
        {
        }

        public override int CalculateRating()
        {
            return Rating; // Приклад реалізації
        }
    }
}