// -----------------------------------------------------------------------
//   <copyright file=App.cs>
//      Copyright © 2022. All Rights Reserved.
//   </copyright>
// -----------------------------------------------------------------------
//  <Author>Vaibhav Lawand</Author>

using System.Windows;

namespace Design_Pattern_Encyclopedia
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Protected Methods

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            UnityBootstrapper unityBootstrapper = new UnityBootstrapper();
            unityBootstrapper.Run();
        }

        #endregion Protected Methods
    }
}