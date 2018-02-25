using HostelManagementSystem.Repo.Imp;
using HostelManagementSystem.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HostelManagementSystem.UI.Views
{
    public partial class DashboardWindow : Window
    {
        MemberRepo MemberRepo = new MemberRepo();
        MealCalculationRepo repo = new MealCalculationRepo();
        public DashboardWindow()
        {
            InitializeComponent();
            LoadAllDropdowns();
            LoadDatagrid();
        }

        private void ManageMembers_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new ManageMembersWindow();
            newWindow.Show();
            this.Close();
        }

        private void CalculateMeal_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new CalculateMealWindow();
            newWindow.Show();
            this.Close();
        }

        private void LoadAllDropdowns()
        {
            ByName.ItemsSource = MemberRepo.GetMembersName();
            ByMonth.ItemsSource = Misc.GetMonth();
            ByYear.ItemsSource = Misc.GetYear();
        }

        private void LoadDatagrid()
        {
            DashboardDatagrid.ItemsSource = repo.GetTotalMeal();
        }
    }
}
