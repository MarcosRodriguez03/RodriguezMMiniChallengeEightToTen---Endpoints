
using Microsoft.AspNetCore.Mvc;
using RodriguezMMiniChallengeEightToTen___Endpoints.GuessIt;


namespace RodriguezMMiniChallengeEightToTen___Endpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class GuessIt : Controller
{
    private readonly IGuessIt _guessItService;

    public GuessIt(IGuessIt GuessItService)
    {
        _guessItService = GuessItService;
    }


    [HttpGet]
    [Route("Pick1-10/{num}")]
    public string EasyMachine(string num)
    {
        return _guessItService.EasyMachine(num);
    }

    [HttpGet]
    [Route("Pick1-50/{num}")]
    public string MediumMachine(string num)
    {
        return _guessItService.MediumMachine(num);
    }

    [HttpGet]
    [Route("Pick1-100/{num}")]
    public string HardMachine(string num)
    {
        return _guessItService.HardMachine(num);
    }
}
