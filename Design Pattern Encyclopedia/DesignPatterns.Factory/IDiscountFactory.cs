// -----------------------------------------------------------------------
//   <copyright file=IDiscountFactory.cs>
//      Copyright © 2022. All Rights Reserved.
//   </copyright>
// -----------------------------------------------------------------------
//  <Author>Vaibhav Lawand</Author>

namespace DesignPatterns.Factory
{
    public interface IDiscountFactory
    {
        #region Public Methods

        IDiscountService GetDiscountService();

        #endregion Public Methods
    }
}