using System;

namespace UnitTestProjectRent
{
    class HourlyRent : Rent
    {

        #region "Constructors"
        public HourlyRent() : base()
        {
        }

        public HourlyRent(int value) : base(value)
        {
        }
        #endregion

        public override decimal Price
        {
            get
            {
                return UnitTestProjectRent.Price.Hour;
            }            
        }

    }
}
