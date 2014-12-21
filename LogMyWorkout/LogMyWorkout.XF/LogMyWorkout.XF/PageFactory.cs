using LogMyWorkout.XF.Models;
using LogMyWorkout.XF.Pages;
using Xamarin.Forms;

namespace LogMyWorkout.XF
{
    public class PageFactory : IPageFactory
    {
        public Page GetPageSecond()
        {
            SecondTestPage page = new SecondTestPage();
            page.Init();
            return page;
        }

        public Page GetExercisesPage()
        {
            ExercisePageViewModel model = new ExercisePageViewModel(new FakeExercisesDataSource());
            ExercisesPage page = new ExercisesPage();
            page.BindingContext = model;
            page.Init();

            return page;
        }
    }
}
