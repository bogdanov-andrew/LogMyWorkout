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
        }

        public ICommand OkCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public string ExerciseName { get; set; }
    }
}
