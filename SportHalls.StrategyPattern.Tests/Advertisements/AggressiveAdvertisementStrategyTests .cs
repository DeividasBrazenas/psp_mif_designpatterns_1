﻿using System;
using SportHalls.StrategyPattern.AdvertisementStrategies;
using SportHalls.StrategyPattern.RentStrategies.Halls.Basketball;
using SportHalls.StrategyPattern.RentStrategies.Halls.Tennis;
using SportHalls.StrategyPattern.RentStrategies.Inventor.Football;
using Xunit;

namespace SportHalls.StrategyPattern.Tests.Advertisements
{
    public class AggressiveAdvertisementStrategyTests
    {
        [Theory]
        [InlineData(01, 01, 02, 01, 3100)]
        [InlineData(01, 31, 02, 27, 2700)]
        public void TennisCourtAgressiveAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable tennisCourt = new Hall(new TennisCourtRentStrategy(), new AggressiveAdvertisementStrategy());
            var cost = tennisCourt.CalculateAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(01, 01, 02, 01, 3100)]
        [InlineData(01, 31, 02, 27, 2700)]
        public void BasketballHallAgressiveAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable basketballHall = new Hall(new BasketballHallRentStrategy(), new AggressiveAdvertisementStrategy());
            var cost = basketballHall.CalculateAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(01, 01, 02, 01, 3100)]
        [InlineData(01, 31, 02, 27, 2700)]
        public void FootballPitchAgressiveAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable footballPitch = new Hall(new FootballRentStrategy(), new AggressiveAdvertisementStrategy());
            var cost = footballPitch.CalculateAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}