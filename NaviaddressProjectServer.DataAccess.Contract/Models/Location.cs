using System;
using System.Collections.Generic;

namespace NaviaddressProjectServer.DataAccess.Contract.Models
{
    public class Location
    {
        public Guid Id { get; set; }

        public string NaviAddress { get; set; }

        public ICollection<Rating> Ratings { get; set; }

        public ICollection<CheckIn> CheckIns { get; set; }
    }
}