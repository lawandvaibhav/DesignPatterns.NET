// -----------------------------------------------------------------------
//   <copyright file=CountryDiscountFactory.cs>
//      Copyright © 2022. All Rights Reserved.
//   </copyright>
// -----------------------------------------------------------------------
//  <Author>Vaibhav Lawand</Author>

namespace DesignPatterns.Factory
{
    internal class CountryDiscountFactory : IDiscountFactory
    {
        #region Private Fields

        private readonly string countryCode;

        #endregion Private Fields

        #region Public Constructors

        public CountryDiscountFactory(string countryCode)
        {
            this.countryCode = countryCode;
        }

        #endregion Public Constructors

        #region Public Methods

        public IDiscountService GetDiscountService()
        {
            return new CountryDiscountService(countryCode);
        }

        #endregion Public Methods
    }
}