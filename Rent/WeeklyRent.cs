using System;

namespace UnitTestProjectRent
{
    class WeeklyRent : Rent
    {

        #region "Constructors"
        public WeeklyRent() : base()
        {
        }

        public WeeklyRent(int value) : base(value)
        {
        }
        #endregion

        public override decimal Price
        {
            get
            {
                return UnitTestProjectRent.Price.Week;
            }            
        }

    }
}
