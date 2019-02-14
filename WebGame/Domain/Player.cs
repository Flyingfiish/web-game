using System;

namespace WebGame.Domain
{
    /// <summary>
    /// Состояние игрока в рамках какой-то запущенной или планируемой игры.
    /// </summary>
    public class Player
    {
        public Player(Guid userId, string name)
        {
            UserId = userId;
            Name = name;
        }

        public Guid UserId { get; }

        /// <summary>
        /// Снэпшот имени игрока на момент старта игры. Считайте, что это такое требование к игре.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Ход, который выбрал игрок
        /// </summary>
        public PlayerDecision Decision { get; set; }
        
        /// <summary>
        /// Текущие очки в игре. Сколько туров выиграл этот игрок.
        /// </summary>
        public int Score { get; set; }
    }
}