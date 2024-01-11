using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguezMMiniChallengeEightToTen___Endpoints.Services.RestaurantPicker
{
    public interface IRestaurantPicker
    {
        public string Pick(string enterCatNum);
    }
}