// -----------------------------------------------------------------------
//   <copyright file=CodeDiscountService.cs>
//      Copyright © 2022. All Rights Reserved.
//   </copyright>
// -----------------------------------------------------------------------
//  <Author>Vaibhav Lawand</Author>

namespace DesignPatterns.Factory
{
    public class CodeDiscountService : IDiscountService
    {
        #region Private Fields

        private readonly string coupenCode;

        #endregion Private Fields

        #region Public Constructors

        public CodeDiscountService(string coupenCode)
        {
            this.coupenCode = coupenCode;
        }

        #endregion Public Constructors

        #region Public Properties

        public double DiscountPercentage
        {
            get
            {
                if (coupenCode.Equals("Coupen30", StringComparison.OrdinalIgnoreCase))
                {
                    return 30;
                }

                // Flat 5 percent discount :)
                return 5;
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