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
            var page = new TestPage();
            var navigationPage = new NavigationPage(page);
            var navigationController = new NavigationController(navigationPage);
            var pageFactory = new PageFactory();
            page.BindingContext = new TestPageViewModel(navigationController, pageFactory);
            page.Init();

            //navigationPage.BindingContext = new TestPageViewModel(navigationPage);

            return navigationPage;
            /*return new ContentPage
            {
                Content = new Label {B
                    Text = "Hello, Forms !",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
            };*/
        }
    }
}
