// -----------------------------------------------------------------------
//   <copyright file=CountryDiscountService.cs>
//      Copyright © 2022. All Rights Reserved.
//   </copyright>
// -----------------------------------------------------------------------
//  <Author>Vaibhav Lawand</Author>

namespace DesignPatterns.Factory
{
    public class CountryDiscountService : IDiscountService
    {
        #region Private Fields

        private readonly string countryCode;

        #endregion Private Fields

        #region Public Constructors

        public CountryDiscountService(string countryCode)
        {
            this.countryCode = countryCode;
        }

        #endregion Public Constructors

        #region Public Properties

        public double DiscountPercentage
        {
            get
            {
                return countryCode switch
                {
                    "US" => 5,
                    "UK" => 7,
                    _ => (double)10,
                };
            }
        }

        #endregion Public Properties

        #region Public Methods

        public override string ToString()
        {
            return GetType().Name;
        }

        #endregion Public Methods
    }
}