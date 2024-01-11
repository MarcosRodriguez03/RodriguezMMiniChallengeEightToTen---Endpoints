using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguezMMiniChallengeEightToTen___Endpoints.Services.RestaurantPicker
{
    public class RestaurantPickerService : IRestaurantPicker
    {
        public string Pick(string enterCatNum)
        {
            int num2 = 0;
            bool isTrue = int.TryParse(enterCatNum, out num2);

            string[] dineIn = { "Lumbejacks Restaurant", "Elkhorn Restaurant", "Fork It", "Market Tavern", "ShiraSoni", "Garlic Brothers", "GK Mongolian BBQ", "Bj's", "El Senor Frog", "Chili's" };
            string[] fastFood = { "Pop Eyes", "McDonalds", "BurgerKing", "Subway", "Wendys", "Taco Bell", "Jack in the Box", "ChickFilA", "Raising Cane's", "Carl's Jr" };
            string[] pizzaPlaces = { "Pizza Hut", "David's Pizza", "Domino", "Eddie's Pizza", "Pizza Guys", "Papa Murphy's", "Pieology", "VIP Pizza", "Mountain Mike's", "Blaze Pizza" };

            if (isTrue)
            {
                Random random = new Random();
                int number = random.Next(0, 10);
                switch (num2)
                {
                    case 1:
                        return $"You should go to {dineIn[number]}";
                    case 2:
                        return $"You should go to {fastFood[number]}";
                    case 3:
                        return $"You should go to {pizzaPlaces[number]}";
                    default:
                        return "pick 1, 2, or 3";
                }
            }
            else
            {
                return " please enter 1 for Dine in, 2 for fast food, or 3 for pizza";
            }




        }
    }
}