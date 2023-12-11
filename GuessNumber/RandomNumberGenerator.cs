using GuessNumber.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    // Принцип инверсии зависимостей (Dependency Inversion Principle)
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly Random _random = new Random();

        public int Generate(int min, int max)
        {
            return _random.Next(min, max + 1);
        }
    }
}
