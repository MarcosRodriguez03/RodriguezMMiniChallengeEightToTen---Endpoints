
using Microsoft.AspNetCore.Mvc;
using RodriguezMMiniChallengeEightToTen___Endpoints.Services.Magic8Ball;


namespace RodriguezMMiniChallengeEightToTen___Endpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class Magic8Ball : ControllerBase
{
    private readonly IMagic8Ball _magic8BallService;

    public Magic8Ball(IMagic8Ball Magic8BallService)
    {
        _magic8BallService = Magic8BallService;
    }

    [HttpGet]
    [Route("ShakeTheMagic8Ball")]

    public string EightBallMachine()
    {
        return _magic8BallService.EightBallMachine();
    }
}
