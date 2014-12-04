using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LogMyWorkout.XF
{
	public class App
	{
		public static Page GetMainPage()
		{
		    var page = new TestPage();
		    ((ContentPage) page).BindingContext = new TestPageViewModel();
		    return page;
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
