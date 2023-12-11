using GuessNumber.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    // Принцип подстановки Барбары Лисков (Liskov Substitution Principle)
    public class GameResultProcessor : IGameResultProcessor
    {
        public void ProcessWin()
        {
            Console.WriteLine("Мои поздравления, Вы победили!");
        }

        public void ProcessLoss(int targetNumber, int userGuess)
        {
            Console.WriteLine($"Нет, загаданное число {(userGuess < targetNumber ? "больше" : "меньше")}!");
        }

        public void ProcessGameOver()
        {
            Console.WriteLine("Увы, но Вы проиграли!");
        }
    }
}
