using System;
using System.Collections.Generic;
using System.Linq;

namespace NaviaddressProjectServer.BusinessLogic.Contract.Models
{
    public class LocationRatings
    {
        public decimal Average =>
            Decimal.Round(
                Convert.ToDecimal(
                    Ratings.Average(rating => rating.Score)),
                decimals: 1);


        public int Count => Ratings.Count;

        public IReadOnlyCollection<Rating> Ratings { get; set; }
    }
}