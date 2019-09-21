﻿using System;

namespace SportHalls.TemplatePattern.Halls.Tennis.RegularPeople
{
    public class TennisCourtPassiveAdvertisement : Hall
    {
        public TennisCourtPassiveAdvertisement(bool isIndoor) : base(isIndoor)
        {
        }

        public override double CalculateSpecificHallRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return startDateTime.Hour < 20 ? rentTimeLength * 0.2 : rentTimeLength * 0.1;
        }

        public override double AdjustCostForMembers(double cost)
        {
            return cost;
        }

        public override double CalculateSpecificHallAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            var advertisementTimeLength = (endDateTime - startDateTime).TotalDays;

            return advertisementTimeLength * 40;
        }
    }
}