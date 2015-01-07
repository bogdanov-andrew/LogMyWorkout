using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LogMyWorkout.XF.Models
{
    public class AddNewExercisePageViewModel
    {
        private readonly INavigation _navigation;

        public AddNewExercisePageViewModel(INavigation navigation)
        {
            _navigation = navigation;

            OkCommand = new Command(OnOkClicked);
            CancelCommand = new Command(OnCancelClicked);
        }

        private void OnCancelClicked()
        {
            _navigation.PopModalAsync();
        }

        private void OnOkClicked()
        {
            IExerciseEntity exerciseEntity = new ExerciseEntity()
            {
                Name = ExerciseName
            };
            MessagingCenter.Send(this, MessagesList.NewExercise, exerciseEntity);
            _navigation.PopModalAsync();
        }

        public ICommand OkCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public string ExerciseName { get; set; }
    }
}
