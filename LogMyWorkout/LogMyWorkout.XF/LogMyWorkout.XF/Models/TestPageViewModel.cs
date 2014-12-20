using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using LogMyWorkout.XF.Pages;
using Xamarin.Forms;

namespace LogMyWorkout.XF.Models
{
    public class TestPageViewModel : INotifyPropertyChanged
    {
        private readonly INavigation _navigation;
        private readonly IPageFactory _pageFactory;
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand StartWorkout { protected set; get; }

        public TestPageViewModel(INavigation navigation, IPageFactory pageFactory)
        {
            _navigation = navigation;
            _pageFactory = pageFactory;
            StartWorkout = new Command(StartWorkoutAction);
        }

        private void StartWorkoutAction()
        {
            Page page = _pageFactory.GetPageSecond();
            _navigation.PushAsync(page);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
