using System;
using System.Collections.Generic;
using System.Text;
using LogMyWorkout.XF.Models;
using Xamarin.Forms;

namespace LogMyWorkout.XF.Pages
{
    public class ExercisesPage : ContentPage
    {
        #region my
        public void Init()
        {
            Grid grid = new Grid()
            {
                RowDefinitions = new RowDefinitionCollection()
                {
                    new RowDefinition(){ Height = new GridLength(5, GridUnitType.Star)},
                    new RowDefinition(){ Height = new GridLength(60, GridUnitType.Star)},
                    new RowDefinition(){ Height = new GridLength(10, GridUnitType.Auto)},
                },

                ColumnDefinitions = new ColumnDefinitionCollection()
                {
                    new ColumnDefinition() {Width = new GridLength(100,GridUnitType.Star)}
                },
            };

            StackLayout topLayout = GenerateTop();
            Grid.SetColumn(topLayout, 0);
            Grid.SetRow(topLayout, 0);
            grid.Children.Add(topLayout);

            ListView middleLayout = GenerateMiddlePart();
            Grid.SetColumn(middleLayout, 0);
            Grid.SetRow(middleLayout, 1);
            grid.Children.Add(middleLayout);

            StackLayout bottomLayout = GenerateBottom();
            Grid.SetColumn(bottomLayout, 0);
            Grid.SetRow(bottomLayout, 2);
            grid.Children.Add(bottomLayout);

            Content = grid;
        }

        private StackLayout GenerateBottom()
        {
            Button startButton = new Button()
            {
                Text = "Start Exercise",
                Command = ((ExercisePageViewModel)BindingContext).StartExercise
            };

            StackLayout layout = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children = { startButton}
            };

            return layout;
        }

        private StackLayout GenerateTop()
        {
            Button searchButton = new Button()
            {
                Text = "Add New Exercise",
                Command = ((ExercisePageViewModel)BindingContext).AddNewExercise
            };

            StackLayout stackLayoutTop = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children = {searchButton}
            };
            return stackLayoutTop;
        }

        private ListView GenerateMiddlePart()
        {
            ListView listView = new ListView
            {
                ItemTemplate = new DataTemplate(() =>
                {
                    Label nameLabel = new Label();
                    nameLabel.SetBinding(Label.TextProperty, "Name");

                    Label idLabel = new Label();
                    idLabel.SetBinding(Label.TextProperty, "Name");

                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Orientation = StackOrientation.Vertical,
                            Children = {idLabel, nameLabel}
                        }
                    };
                }),
            };

            listView.SetBinding(ListView.ItemsSourceProperty, "ExercisesList");
            listView.SetBinding(ListView.SelectedItemProperty, "SelectedExerciseEntity");

            return listView;
        }

        #endregion
    }
}
