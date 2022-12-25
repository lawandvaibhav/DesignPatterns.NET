// -----------------------------------------------------------------------
//   <copyright file=Logger.cs>
//      Copyright © 2022. All Rights Reserved.
//   </copyright>
// -----------------------------------------------------------------------
//  <Author>Vaibhav Lawand</Author>

using Prism.Ioc;
using Prism.Unity;
using System.Windows;

namespace Design_Pattern_Encyclopedia
{
    internal class UnityBootstrapper : PrismBootstrapper
    {
        #region Protected Methods

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        #endregion Protected Methods
    }
}