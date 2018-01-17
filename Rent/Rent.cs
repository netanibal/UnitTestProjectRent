using System;

namespace UnitTestProjectRent
{
    abstract class Rent
    {
        int _value;

        #region "Constructors"
        public Rent()
        {
        }
        public Rent(int value): this()
        {
            _value = value;
        }
        #endregion

        abstract public decimal Price { get;}
        public int Value 
        {
            get { return _value; }
            set { _value = value; }
        }

        public decimal Total()
        {
            return this.Value * this.Price;
        }
              
    }
}
