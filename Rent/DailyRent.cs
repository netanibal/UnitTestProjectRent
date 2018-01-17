using System;

namespace UnitTestProjectRent
{
    class DailyRent : Rent
    {

        #region "Constructors"
        public DailyRent() : base()
        {
        }

        public DailyRent(int value) : base(value)
        {
        }
        #endregion

        public override decimal Price
        {
            get
            {
                return UnitTestProjectRent.Price.Day;
            }            
        }

    }
}
