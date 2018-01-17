using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProjectRent
{
    [TestClass()]
    public class PriceTest
    {
        /// <summary>
        /// Method for testing rentals
        /// </summary>
        [TestMethod()]
        public void Price()
        {
            decimal totalPricePerHour = new HourlyRent(4).Total();
            decimal totalPricePerDay = new DailyRent(3).Total();
            decimal totalPricePerWeek = new WeeklyRent(2).Total();
        }

        /// <summary>
        /// Method for testing family discounts
        /// </summary>
        [TestMethod()]
        public void PriceFamily()
        {
            List<Rent> rentals = new List<Rent>();
            rentals.Add(new DailyRent(1));
            rentals.Add(new HourlyRent(4));
            rentals.Add(new WeeklyRent(2));
            rentals.Add(new WeeklyRent(5));

            decimal total = rentals.Sum(x => x.Total());

            if (WithDiscount(rentals))
                total -= (total * UnitTestProjectRent.Price.Discount);
        }

        /// <summary>
        /// Method for evaluating the conditions to apply the discount
        /// </summary>
        /// <param name="rentals">List of rentals</param>
        /// <returns></returns>
        private bool WithDiscount(List<Rent> rentals)
        {
            if (rentals != null)
                return rentals.Count >= 3 && rentals.Count <= 5;
            else
                return false;
        }
    }

}