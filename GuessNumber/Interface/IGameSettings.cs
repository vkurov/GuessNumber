using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Interface
{
    // Принцип открытости/закрытости (Open/Closed Principle)
    public interface IGameSettings
    {
        int MinNumber { get; }
        int MaxNumber { get; }
        int MaxAttempts { get; }
    }
}
