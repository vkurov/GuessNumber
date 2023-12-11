using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessNumber.Interface;

namespace GuessNumber
{
    public class Game
    {
        private readonly IGameSettings _gameSettings;
        private readonly IRandomNumberGenerator _randomNumberGenerator;
        private readonly IGameResultProcessor _gameResultProcessor;

        public Game(IGameSettings gameSettings, IRandomNumberGenerator randomNumberGenerator, IGameResultProcessor gameResultProcessor)
        {
            _gameSettings = gameSettings;
            _randomNumberGenerator = randomNumberGenerator;
            _gameResultProcessor = gameResultProcessor;
        }

        public void Start()
        {
            int targetNumber = _randomNumberGenerator.Generate(_gameSettings.MinNumber, _gameSettings.MaxNumber);
            int attempts = 0;
            Console.Write("Я загадал число, сумеете ли Вы его отгадать?\n");
            while (attempts < _gameSettings.MaxAttempts)
            {
                int userGuess = GetUserGuess();
                if (userGuess == targetNumber)
                {
                    _gameResultProcessor.ProcessWin();
                    return;
                }
                _gameResultProcessor.ProcessLoss(targetNumber, userGuess);
                attempts++;
            }
            _gameResultProcessor.ProcessGameOver();
        }

        private int GetUserGuess()
        {
            Console.Write("Введите число: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
