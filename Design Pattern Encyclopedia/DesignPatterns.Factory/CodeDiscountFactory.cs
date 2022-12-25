// -----------------------------------------------------------------------
//   <copyright file=CodeDiscountFactory.cs>
//      Copyright © 2022. All Rights Reserved.
//   </copyright>
// -----------------------------------------------------------------------
//  <Author>Vaibhav Lawand</Author>

namespace DesignPatterns.Factory
{
    public class CodeDiscountFactory : IDiscountFactory
    {
        #region Private Fields

        private readonly string coupenCode;

        #endregion Private Fields

        #region Public Constructors

        public CodeDiscountFactory(string coupenCode)
        {
            this.coupenCode = coupenCode;
        }

        #endregion Public Constructors

        #region Public Methods

        public IDiscountService GetDiscountService()
        {
            return new CodeDiscountService(coupenCode);
        }

        #endregion Public Methods
    }
}