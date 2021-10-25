using System;

namespace SandBox
{
    public class Fraction
    {
        #region MyRegion

        private int _x;
        private int _y;

        #endregion

        #region Constructors

        public Fraction(int x, int y)
        {
            if (y == 0) { throw new ArgumentException("Cannot divide by zero.", nameof(y)); }
            
            _x = x;
            _y = y;
        }

        #endregion

        #region Methods

        public double GetValue()
        {
            return (double)_x / _y;
        }

        #endregion

    }
}