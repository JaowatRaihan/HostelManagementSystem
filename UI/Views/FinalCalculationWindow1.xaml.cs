using HostelManagementSystem.Entity;
using HostelManagementSystem.Repo.Imp;
using HostelManagementSystem.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace HostelManagementSystem.UI.Views
{
    public partial class FinalCalculationWindow1 : Window
    {
        MealCalculationRepo repo = new MealCalculationRepo();
        List<MealCalculationMainStep> list;
        List<MealCalculationFinalStep> finalStep = new List<MealCalculationFinalStep>();

        public FinalCalculationWindow1()
        {
            InitializeComponent();                
            list = (List<MealCalculationMainStep>)Application.Current.Resources["mainStep"];
            Month.Content += list.FirstOrDefault().Month;
            CalculateMealrate();
        }

        private void CalculateMealrate()
        {
            double totalBazar = 0, mealRate = 0;
            int totalMeal = 0;

            foreach (var item in list)
            {
                totalBazar += item.Bazar;
                totalMeal += item.Meal;
            }

            mealRate = Math.Round(Convert.ToDouble(totalBazar / totalMeal), 2); ;

            foreach (var item in list)
            {
                MealCalculationFinalStep MealCalculationFinalStep = new MealCalculationFinalStep();
                MealCalculationFinalStep.Name = item.Name;
                MealCalculationFinalStep.Bazar = item.Bazar;
                MealCalculationFinalStep.RealCost = Math.Round((mealRate * item.Meal), MidpointRounding.AwayFromZero);
                MealCalculationFinalStep.Balance = MealCalculationFinalStep.Bazar - MealCalculationFinalStep.RealCost;
                MealCalculationFinalStep.MealCount = item.Meal;

                finalStep.Add(MealCalculationFinalStep);
            }

            Cart.ItemsSource = finalStep;
            TotalBazar.Content = totalBazar.ToString();
            TotalMeal.Content = totalMeal.ToString();
            MealRate.Content = mealRate.ToString();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                List<MonthlyMealTotal> _mealTotal = new List<MonthlyMealTotal>();
                foreach (var item in finalStep)
                {
                    MonthlyMealTotal _total = new MonthlyMealTotal();
                    _total.Name = item.Name;
                    _total.Month = list.FirstOrDefault().Month;
                    _total.Year = list.FirstOrDefault().Year;
                    _total.Status = "Pending";
                    _total.Bazar = item.Bazar;
                    _total.Balance = Convert.ToInt32(item.Balance);
                    _total.RealCost = Convert.ToInt32(item.RealCost);

                    _mealTotal.Add(_total);
                }
                Application.Current.Resources["list"] = null;
                Application.Current.Resources["mainStep"] = null;
                repo.InsertTotalMeal(_mealTotal);
                MessageBox.Show("Saved!!");
                var newWindow = new DashboardWindow();
                newWindow.Show();
                this.Close();
            }
            else
                MessageBox.Show("Not Saved!!");
        }

        private void ReCalculate_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["list"] = null;
            Application.Current.Resources["mainStep"] = null;
            var newWindow = new CalculateMealWindow();
            newWindow.Show();
            this.Close();
        }
    }
}
