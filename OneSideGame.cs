using GameNamespace;

namespace GameNamespace
{
    public class OneSideGame : BaseGame
    {
        public bool isRatingForPlayer1;
        public OneSideGame(string opponentName, int rating)
            : base(opponentName, rating) // Викликаємо конструктор базового класу
        {
            // Додаткова логіка, якщо потрібно
        }

      

    public override int CalculateRating() 
    {
        if (isRatingForPlayer1) 
        {
            // Рейтинг змінюється тільки для гравця 1
            return Rating;
        }
        else 
        {
            // Рейтинг не змінюється для опонента
            return 0; 
        }
    }
    }
}
