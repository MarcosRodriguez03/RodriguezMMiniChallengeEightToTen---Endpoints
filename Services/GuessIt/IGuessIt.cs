using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguezMMiniChallengeEightToTen___Endpoints.GuessIt
{
    public interface IGuessIt
    {
        public string EasyMachine(string num);
        public string MediumMachine(string num);
        public string HardMachine(string num);
    }
}