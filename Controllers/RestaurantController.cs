
using Microsoft.AspNetCore.Mvc;
using RodriguezMMiniChallengeEightToTen___Endpoints.Services.RestaurantPicker;


namespace RodriguezMMiniChallengeEightToTen___Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantController : ControllerBase
{
    private readonly IRestaurantPicker _restaurantPicker;

    public RestaurantController(IRestaurantPicker restaurantPicker)
    {
        _restaurantPicker = restaurantPicker;
    }

    [HttpGet]
    [Route("Enter1ForDineInEnter2ForFastFoodEnter3ForPizza/{enterCatNum}")]

    public string Pick(string enterCatNum)
    {
        return _restaurantPicker.Pick(enterCatNum);
    }
}
