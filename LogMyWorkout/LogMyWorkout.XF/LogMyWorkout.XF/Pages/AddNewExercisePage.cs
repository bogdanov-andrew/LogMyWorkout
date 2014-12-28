using System;
using System.Collections.Generic;
using System.Text;
using Java.Nio;
using LogMyWorkout.XF.Models;
using Xamarin.Forms;

namespace LogMyWorkout.XF.Pages
{
    public class AddNewExercisePage : ContentPage
    {
        public void Init()
        {
            Grid grid = new Grid()
            {
                ColumnDefinitions = new ColumnDefinitionCollection()
                {
                    new ColumnDefinition() {Width = new GridLength(15, GridUnitType.Star)},
                    new ColumnDefinition() {Width = new GridLength(40, GridUnitType.Star)}
                },

                RowDefinitions = new RowDefinitionCollection()
                {
                    new RowDefinition() {Height = new GridLength(10,GridUnitType.Star)},
                    new RowDefinition() {Height = new GridLength(10, GridUnitType.Absolute)},
                    //new RowDefinition() {Height = new GridLength(10, GridUnitType.Star)}
                }
            };

            Label exerciseNameLabel = new Label()
            {
                Text = "Name",
                XAlign = TextAlignment.End
            };
            PlaceToGrid(grid, 0, 1, exerciseNameLabel);

            Entry exerciseNameEntry = new Entry();
            exerciseNameEntry.SetBinding(Entry.TextProperty, "ExerciseName");
            PlaceToGrid(grid, 1, 1, exerciseNameEntry);

            Button okButton = new Button()
            {
                Text = "Ok",
                Command = ((AddNewExercisePageViewModel)BindingContext).OkCommand
            };

            Button cancelButton = new Button()
            {
                Text = "Cancel",
                Command = ((AddNewExercisePageViewModel)BindingContext).CancelCommand
            };

            StackLayout buttonLayout = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children = { okButton, cancelButton }
            };

            PlaceToGrid(grid, 1, 2, buttonLayout);

            Content = grid;
        }

        private void PlaceToGrid(Grid grid, int column, int row, View control)
        {
            Grid.SetColumn(control, column);
            Grid.SetRow(control, row);
            grid.Children.Add(control);

        }
    }
}
