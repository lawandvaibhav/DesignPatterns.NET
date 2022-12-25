// -----------------------------------------------------------------------
//   <copyright file=IDiscountService.cs>
//      Copyright © 2022. All Rights Reserved.
//   </copyright>
// -----------------------------------------------------------------------
//  <Author>Vaibhav Lawand</Author>

namespace DesignPatterns.Factory
{
    public interface IDiscountService
    {
        #region Public Properties

        double DiscountPercentage { get; }

        #endregion Public Properties
    }
}