using GameNamespace;

namespace GameNamespace
{
    public class TrainingGame : BaseGame
    {
        public TrainingGame(string opponentName)
            : base(opponentName, 0) // Передаємо rating = 0 для тренувальних ігор
        {
        }

        public override int CalculateRating()
        {
            return 0; // У тренувальних іграх рейтинг не змінюється
        }
    }
}
