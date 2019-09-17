﻿using System;
using SportHalls.StrategyPattern.InventorRent.Football;
using Xunit;

namespace SportHalls.StrategyPattern.Tests.Inventor
{
    public class FootballInventorUnitTests
    {
        [Theory]
        [InlineData(19, 00, 21, 00, 3.6)]
        [InlineData(21, 30, 23, 00, 2.7)]
        public void FootballRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable football = new InventorRent.Inventor(new FootballRentStrategy());
            var cost = football.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}