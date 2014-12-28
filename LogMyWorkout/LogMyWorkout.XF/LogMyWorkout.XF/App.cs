using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogMyWorkout.XF.Models;
using LogMyWorkout.XF.Pages;
using Xamarin.Forms;

namespace LogMyWorkout.XF
{
    public class App
    {
        public static Page GetMainPage()
        {
            var page = new StartPage();
            var navigationPage = new NavigationPage(page);
            var navigationController = new NavigationController(navigationPage);
            var pageFactory = new PageFactory(navigationController);
            page.BindingContext = new StartPageViewModel(navigationController, pageFactory);
            page.Init();

            return navigationPage;
        }
    }
}
