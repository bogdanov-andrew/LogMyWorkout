using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LogMyWorkout.XF
{
    public class NavigationController : INavigation
    {
        private readonly INavigation _navigation;

        public NavigationController(NavigationPage navigationPage)
        {
            _navigation = navigationPage.Navigation;
        }

        public Task PushAsync(Page page)
        {
            return _navigation.PushAsync(page);
        }

        public Task<Page> PopAsync()
        {
            return _navigation.PopAsync();
        }

        public Task PopToRootAsync()
        {
            return _navigation.PopToRootAsync();
        }

        public Task PushModalAsync(Page page)
        {
            return _navigation.PushModalAsync(page);
        }

        public Task<Page> PopModalAsync()
        {
            return _navigation.PopModalAsync();
        }
    }
}
