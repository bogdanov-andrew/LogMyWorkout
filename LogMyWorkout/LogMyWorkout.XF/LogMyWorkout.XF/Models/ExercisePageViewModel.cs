using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using LogMyWorkout.XF.Droid.Annotations;
using Xamarin.Forms;

namespace LogMyWorkout.XF.Models
{
    public class ExercisePageViewModel : INotifyPropertyChanged
    {
        private readonly IExerciseDataSource _exerciseDataSource;
        private readonly INavigation _navigation;
        private readonly IPageFactory _pageFactory;
        public ICommand AddNewExercise { get; set; }
        public ICommand SearchExercise { get; set; }
        public ICommand StartExercise { get; set; }

        public string SearchBoxText { get; set; }

        public IList<IExerciseEntity> ExercisesList { get; private set; }

        public IExerciseEntity SelectedExerciseEntity { get; set; }

        private void InitExerciseList()
        {
            ExercisesList = _exerciseDataSource.GetAvaliableExercises();
        }

        public ExercisePageViewModel(IExerciseDataSource exerciseDataSource, INavigation navigation, IPageFactory pageFactory)
        {
            _exerciseDataSource = exerciseDataSource;
            _navigation = navigation;
            _pageFactory = pageFactory;

            InitExerciseList();
            
            AddNewExercise = new Command(OnAddNewExercise);
            SearchExercise = new Command(OnSearchExercise);
            StartExercise = new Command(OnStartExercise);
        }

        private void OnStartExercise()
        {
            
        }

        private void OnSearchExercise()
        {
            
        }

        private void OnAddNewExercise()
        {
            Page page = _pageFactory.GetAddNewExercisePage();
            _navigation.PushModalAsync(page);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
