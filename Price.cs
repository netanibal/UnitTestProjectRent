using System;

namespace UnitTestProjectRent
{
    public static class Price
    {
        const decimal PRICE_HOUR = 5;
        const decimal PRICE_DAY = 20;
        const decimal PRICE_WEEK = 60;
        const decimal DISCOUNT = 30;

        public static decimal Hour
        {
            get
            {
                return PRICE_HOUR;
            }
        }

        public static decimal Day
        {
            get
            {
                return PRICE_DAY;
            }
        }

        public static decimal Week
        {
            get
            {
                return PRICE_WEEK;
            }
        }

        public static decimal Discount
        {
            get
            {
                return DISCOUNT / 100;
            }
        }

    }
}
