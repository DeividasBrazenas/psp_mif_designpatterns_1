﻿using System;

namespace SportHalls.TemplatePattern.Inventor.Tennis
{
    public class TennisBalls : Inventor
    {
        public override double CalculateSpecificItemRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.04;
        }

        public override double AdjustCostForMembers(double cost)
        {
            return cost;
        }
    }
}