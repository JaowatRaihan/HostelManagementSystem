using HostelManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagementSystem.Repo
{
    public interface IMealCalculationRepo
    {
        List<MonthlyMealTotal> GetTotalMeal();
        List<MonthlyMealTotal> GetMonthlyMealTotal(string Month, string Year);
        List<MonthlyMealTotal> GetTotalMealByUser(string Name);
        List<MonthlyMealTotal> GetMonthlyMealTotalByUser(string Name, string month, string year);
        void InsertTotalMeal(List<MonthlyMealTotal> monthlyMealTotal);
    }
}
