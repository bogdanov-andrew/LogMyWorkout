using LogMyWorkout.XF.Models;
using LogMyWorkout.XF.Pages;
using Xamarin.Forms;

namespace LogMyWorkout.XF
{
    public class PageFactory : IPageFactory
    {
        private INavigation _navigation;

        public PageFactory(INavigation navigation)
        {
            _navigation = navigation;
        }

        public Page GetAddNewExercisePage()
        {
            AddNewExercisePageViewModel model = new AddNewExercisePageViewModel(_navigation);
            AddNewExercisePage page = new AddNewExercisePage();
            page.BindingContext = model;
            page.Init();
            return page;
        }

        public Page GetExercisesPage()
        {
            ExercisePageViewModel model = new ExercisePageViewModel(new FakeExercisesDataSource(), _navigation, this);
            ExercisesPage page = new ExercisesPage();
            page.BindingContext = model;
            page.Init();

            return page;
        }
    }
}
