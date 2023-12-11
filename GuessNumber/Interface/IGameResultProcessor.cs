using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Interface
{
    public interface IGameResultProcessor
    {
        void ProcessWin();
        void ProcessLoss(int targetNumber, int userGuess);
        void ProcessGameOver();
    }
}
