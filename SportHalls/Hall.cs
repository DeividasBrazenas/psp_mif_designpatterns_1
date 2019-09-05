﻿using System;
using SportHalls.StrategyPattern.RentStrategy;

namespace SportHalls.StrategyPattern
{
    public class Hall : IHall
    {
        private readonly IRentStrategy _rentStrategy;

        public Hall(IRentStrategy rentStrategy)
        {
            _rentStrategy = rentStrategy;
        }

        public double CalculateHallRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            return _rentStrategy.CalculateRentCost(startDateTime, endDateTime);
        }
    }
}