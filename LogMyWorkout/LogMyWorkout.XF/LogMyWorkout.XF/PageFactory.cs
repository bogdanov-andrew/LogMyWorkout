using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
