using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LogMyWorkout.XF
{
    public class NavigationController : INavigation
    {
        private readonly NavigationPage _navigationPage;

        public NavigationController(NavigationPage navigationPage)
        {
            _navigationPage = navigationPage;
        }

        public Task PushAsync(Page page)
        {
            return _navigationPage.PushAsync(page);
        }

        public Task<Page> PopAsync()
        {
            return _navigationPage.PopAsync();
        }

        public Task PopToRootAsync()
        {
            return _navigationPage.PopToRootAsync();
        }

        public Task PushModalAsync(Page page)
        {
            throw new NotSupportedException();
        }

        public Task<Page> PopModalAsync()
        {
            throw new NotSupportedException();
        }
    }
}
