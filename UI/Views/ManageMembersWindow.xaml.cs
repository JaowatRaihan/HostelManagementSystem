using HostelManagementSystem.Entity;
using HostelManagementSystem.Repo.Imp;
using System.Windows;

namespace HostelManagementSystem.UI.Views
{
    public partial class ManageMembersWindow : Window
    {
        MemberRepo repo = new MemberRepo();
        public ManageMembersWindow()
        {
            InitializeComponent();
            Refresh();
            AllMembers();
        }

        private void AllMembers()
        {
            LoadAllMembers.ItemsSource = repo.GetAll();
        }

        private void AddMember_Click(object sender, RoutedEventArgs e)
        {
            Member member = new Member();
            member.Name = Name.Text;
            member.Phone = Phone.Text;

            int id = repo.AddMember(member);

            Refresh();
            AllMembers();
        }

        private void Refresh()
        {
            Name.Clear();
            Phone.Clear();
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new DashboardWindow();
            newWindow.Show();
            this.Close();
        }

        private void CalculateMeal_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new CalculateMealWindow();
            newWindow.Show();
            this.Close();
        }
    }
}
