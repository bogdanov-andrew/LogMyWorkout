using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace LogMyWorkout.XF
{
    public class TestPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand StartWorkout { protected set; get; }

        public TestPageViewModel()
        {
            StartWorkout = new Command(StartWorkoutAction);
        }

        private void StartWorkoutAction()
        {
               
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
