﻿using System;

namespace SportHalls.TemplatePattern.Halls.Basketball
{
    public class BasketballHallForMembersNoAdvertisement : Hall
    {
        public BasketballHallForMembersNoAdvertisement(bool isIndoor) : base(isIndoor)
        {
        }

        public override double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.1;
        }

        public override double AdjustCost(double cost)
        {
            return cost * 0.8;
        }

        public override double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            return 0;
        }
    }
}