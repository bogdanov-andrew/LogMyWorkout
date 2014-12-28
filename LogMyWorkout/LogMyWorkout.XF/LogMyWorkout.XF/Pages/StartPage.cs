using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using LogMyWorkout.XF.Models;
using Xamarin.Forms;

namespace LogMyWorkout.XF.Pages
{
    public class StartPage : ContentPage
    {
        public void Init()
        {
            Button letsStartButton = new Button
            {
                Text = "Let's start!",
                Command = ((StartPageViewModel)BindingContext).StartWorkout
            };

            StackLayout stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { letsStartButton }
            };

            Content = stackLayout;
        }
    }
}
