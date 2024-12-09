namespace GameNamespace
{
    public abstract class BaseGame
    {
        private static int UnicId = 1;
        public int GameId { get; private set; }
        public string OpponentName { get; set; }
       public string? Result { get; set; }
        public int Rating { get; set; }

      public BaseGame(string opponentName, int rating)
        {
            OpponentName = opponentName;
            Rating = rating;
            GameId = UnicId++;
            Result = "Unspecified"; // Ініціалізація значення за замовчуванням для Result
        }

        public abstract int CalculateRating();
    }
}
