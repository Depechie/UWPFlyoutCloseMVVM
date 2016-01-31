using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Practices.ServiceLocation;

namespace UWPFlyoutCloseMVVM.ViewModels
{
    public class ViewModelLocator
    {
        private static void Register<T>(bool createImmediately = false) where T : class
        {
            SimpleIoc.Default.Register<T>(createImmediately);
        }

        internal static T Get<T>() where T : class
        {
            return SimpleIoc.Default.GetInstance<T>();
        }

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<IMessenger, Messenger>();

            Register<MainViewModel>();
        }

        public MainViewModel Main => Get<MainViewModel>();
    }
}
