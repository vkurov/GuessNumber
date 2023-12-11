using GuessNumber.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    public class GameSettings : IGameSettings
    {
        public GameSettings(int MinNumber, int MaxNumber, int MaxAttempts) 
        {
            this.MinNumber = MinNumber;
            this.MaxNumber = MaxNumber;
            this.MaxAttempts = MaxAttempts;
        }
        public int MinNumber {get;set;}

        public int MaxNumber {get;set;}

        public int MaxAttempts { get; set; }
    }
}
