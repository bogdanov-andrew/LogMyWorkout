using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LogMyWorkout.XF
{
    public interface IPageFactory
    {
        Page GetPageSecond();
        Page GetExercisesPage();
    }
}
