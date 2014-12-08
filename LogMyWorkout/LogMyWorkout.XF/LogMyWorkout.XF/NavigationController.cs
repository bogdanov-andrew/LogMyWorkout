using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LogMyWorkout.XF.Droid
{
    public class NavigationController : INavigation
    {
        public Task PushAsync(Page page)
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopAsync()
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync()
        {
            throw new NotImplementedException();
        }

        public Task PushModalAsync(Page page)
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopModalAsync()
        {
            throw new NotImplementedException();
        }
    }
}
