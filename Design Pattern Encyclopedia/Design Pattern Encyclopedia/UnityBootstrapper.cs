using Prism.Ioc;
using Prism.Unity;
using System.Windows;

namespace Design_Pattern_Encyclopedia
{
    internal class UnityBootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
