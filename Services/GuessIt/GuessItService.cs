using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguezMMiniChallengeEightToTen___Endpoints.GuessIt
{
    public class GuessItService : IGuessIt
    {
        public string EasyMachine(string num)
        {
            int num2 = 0;
            bool istrue = int.TryParse(num, out num2);

            Random random = new Random();
            int rnd = random.Next(1, 11);

            if (istrue)
            {

                if (rnd == num2)
                {
                    return $"You got it, number was {rnd}";
                }
                else if (rnd > num2)
                {
                    return $"To Low, you guessed {num} but the number was {rnd}";
                }
                else
                {
                    return $"To High, you guessed {num} but the number was {rnd}";
                }

            }
            else
            {
                return $"You entered {num}. Please enter a valid whole number";
            }
        }

        public string MediumMachine(string num)
        {
            int num2 = 0;
            bool istrue = int.TryParse(num, out num2);

            Random random = new Random();
            int rnd = random.Next(1, 51);

            if (istrue)
            {

                if (rnd == num2)
                {
                    return $"You got it, number was {rnd}";
                }
                else if (rnd > num2)
                {
                    return $"To Low, you guessed {num} but the number was {rnd}";
                }
                else
                {
                    return $"To High, you guessed {num} but the number was {rnd}";
                }

            }
            else
            {
                return $"You entered {num}. Please enter a valid whole number";
            }
        }

        public string HardMachine(string num)
        {
            int num2 = 0;
            bool istrue = int.TryParse(num, out num2);

            Random random = new Random();
            int rnd = random.Next(1, 101);

            if (istrue)
            {

                if (rnd == num2)
                {
                    return $"You got it, number was {rnd}";
                }
                else if (rnd > num2)
                {
                    return $"To Low, you guessed {num} but the number was {rnd}";
                }
                else
                {
                    return $"To High, you guessed {num} but the number was {rnd}";
                }

            }
            else
            {
                return $"You entered {num}. Please enter a valid whole number";
            }
        }
    }
}