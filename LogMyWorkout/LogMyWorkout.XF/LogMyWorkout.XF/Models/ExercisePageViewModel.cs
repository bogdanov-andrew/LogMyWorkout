using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace LogMyWorkout.XF.Models
{
    public class ExercisePageViewModel : INotifyPropertyChanged
    {
        private readonly IExerciseDataSource _exerciseDataSource;
        public ICommand AddNewExercise { get; set; }
        public ICommand SearchExercise { get; set; }

        public string SearchBoxText { get; set; }

        public IList<IExerciseEntity> ExercisesList { get; private set; }

        public IExerciseEntity SelectedExerciseEntity { get; set; }

        private void InitExerciseList()
        {
            ExercisesList = _exerciseDataSource.GetAvaliableExercises();
        }

        public ExercisePageViewModel(IExerciseDataSource exerciseDataSource)
        {
            _exerciseDataSource = exerciseDataSource;

            InitExerciseList();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //[NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
