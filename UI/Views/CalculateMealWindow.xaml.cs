using HostelManagementSystem.Repo.Imp;
using HostelManagementSystem.UI.Models;
using System;
using System.Collections.Generic;
using System.Windows;
namespace HostelManagementSystem.UI.Views
{
    public partial class CalculateMealWindow : Window
    {
        MemberRepo repo = new MemberRepo();
        List<MealCalculationFirstStep> list;
        string _Month = null, _Year = null;

        public CalculateMealWindow()
        {
            InitializeComponent();
            Refresh();
            Calculate.Visibility = Visibility.Hidden;
        }

        private void Refresh()
        {
            ChooseMonth.ItemsSource = null;
            ChooseYear.ItemsSource = null;
            ChooseUser.ItemsSource = null;
            Cart.ItemsSource = null;

            ChooseUser.ItemsSource = repo.GetMembersName();
            ChooseMonth.ItemsSource = Misc.GetMonth();
            ChooseYear.ItemsSource = Misc.GetYear();

            BazarAmount.Text = "";
            MealCount.Text = "";

            Application.Current.Resources["list"] = null;
            Application.Current.Resources["UsersList"] = null;

            ChooseYear.IsEnabled = true;
            ChooseMonth.IsEnabled = true;

            _Year = null;
            _Month = null;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MealCalculationFirstStep mealCalculationFirstStep = new MealCalculationFirstStep();
            mealCalculationFirstStep.Name = ChooseUser.SelectedItem.ToString();
            mealCalculationFirstStep.Bazar = Convert.ToDouble(BazarAmount.Text);
            mealCalculationFirstStep.Meal = Convert.ToInt32(MealCount.Text.ToString());

            if( _Month == null && _Year == null)
            {
                _Month = ChooseMonth.SelectedItem.ToString();
                _Year = ChooseYear.SelectedItem.ToString();
            }

            if (Application.Current.Resources["list"] == null)
            {
                list = new List<MealCalculationFirstStep>();
            }
            else
            {
                list = (List<MealCalculationFirstStep>)Application.Current.Resources["list"];
            }

            list.Add(mealCalculationFirstStep);
            Application.Current.Resources["list"] = list; 
            Cart.ItemsSource = null;
            Cart.ItemsSource = list;

            BazarAmount.Text = "";
            MealCount.Text = "";

            if (Application.Current.Resources["UsersList"] == null)
            {
                Application.Current.Resources["UsersList"] = repo.GetMembersName();
            }

            var x = (List<string>)Application.Current.Resources["UsersList"];
            if (x.Contains(ChooseUser.SelectedItem.ToString()))
            {
                x.Remove(ChooseUser.SelectedItem.ToString());
            }
            Application.Current.Resources["UsersList"] = x;          
            ChooseUser.ItemsSource = null;
            ChooseUser.ItemsSource = x;

            if(list != null)
            {
                ChooseYear.IsEnabled = false;
                ChooseMonth.IsEnabled = false;
            }

            if (repo.GetMembersName().Count == list.Count)
                Calculate.Visibility = Visibility.Visible;
        }        
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            List<MealCalculationMainStep> mainStep = new List<MealCalculationMainStep>();
            list = (List<MealCalculationFirstStep>)Application.Current.Resources["list"];

            foreach (var item in list)
            {
                MealCalculationMainStep mealCalculationMainStep = new MealCalculationMainStep();
                mealCalculationMainStep.Name = item.Name;
                mealCalculationMainStep.Bazar = item.Bazar;
                mealCalculationMainStep.Meal = item.Meal;
                mealCalculationMainStep.Month = ChooseMonth.SelectedItem.ToString();
                mealCalculationMainStep.Year = ChooseYear.SelectedItem.ToString();

                mainStep.Add(mealCalculationMainStep);
            }
            Application.Current.Resources["mainStep"] = mainStep;

            var newWindow = new FinalCalculationWindow1();
            newWindow.Show();
            this.Close();
        }
        private void _Refresh_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
            var newWindow = new DashboardWindow();
            newWindow.Show();
            this.Close();
        }
        private void ManageUsers_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
            var newWindow = new ManageMembersWindow();
            newWindow.Show();
            this.Close();
        }
    }
}
