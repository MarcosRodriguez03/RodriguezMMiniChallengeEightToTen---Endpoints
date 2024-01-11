using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguezMMiniChallengeEightToTen___Endpoints.Services.Magic8Ball;

public class Magic8BallService : IMagic8Ball
{
    public string EightBallMachine()
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 9);

        switch (number)
        {
            case 1:
                return "Idk prob not, go ask your mom or smth";

            case 2:
                return "yeah sure if you want";

            case 3:
                return "thats dumb, no";

            case 4:
                return "ew";

            case 5:
                return "hmmm... sure";

            case 6:
                return "dude im just a ball. go fix your own problems";

            case 7:
                return "ya";

            case 8:
                return "most likley maybe";

        }

        return "";



    }
}
