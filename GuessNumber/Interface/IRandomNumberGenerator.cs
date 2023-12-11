using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Interface
{
    public interface IRandomNumberGenerator
    {
        int Generate(int min, int max);
    }
}
