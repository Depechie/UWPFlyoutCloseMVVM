using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace UWPFlyoutCloseMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private bool _isFlyoutClosed;
        public bool IsFlyoutClosed
        {
            get { return _isFlyoutClosed; }
            set
            {
                Set(() => IsFlyoutClosed, ref _isFlyoutClosed, value);
                if (value)
                    IsFlyoutClosed = false;
            }
        }

        private RelayCommand _longCodeCommand;
        public RelayCommand LongCodeCommand => _longCodeCommand ?? (_longCodeCommand = new RelayCommand(LongCode));

        public MainViewModel(IMessenger messenger) : base(messenger)
        {
        }

        public void LongCode()
        {
            IsFlyoutClosed = true;
        }
    }
}
