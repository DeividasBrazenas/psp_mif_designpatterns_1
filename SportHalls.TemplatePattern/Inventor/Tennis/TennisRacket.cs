﻿using System;

namespace SportHalls.TemplatePattern.Inventor.Tennis
{
    public class TennisRacket : Inventor
    {
        public override double CalculateSpecificItemRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.05;
        }

        public override double AdjustCostForMembers(double cost)
        {
            return cost;
        }
    }
}