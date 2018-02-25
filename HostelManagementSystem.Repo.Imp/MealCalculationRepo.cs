using System.Collections.Generic;
using System.Linq;
using HostelManagementSystem.Entity;
using HostelManagementSystem.Data;

namespace HostelManagementSystem.Repo.Imp
{
    public class MealCalculationRepo : IMealCalculationRepo
    {
        MealCalculationDBContext context = new MealCalculationDBContext();
        public List<MonthlyMealTotal> GetTotalMeal()
        {
            var p = 0;
            var result = context.MonthlyMealTotal.ToList();
            return result;
        }
        public List<MonthlyMealTotal> GetMonthlyMealTotal(string Month, string Year)
        {
            var result = context.MonthlyMealTotal.ToList();
            return result;
        }
        public List<MonthlyMealTotal> GetTotalMealByUser(string Name)
        {
            var result = context.MonthlyMealTotal.Where(a => a.Name == Name).ToList();
            return result;
        }
        public List<MonthlyMealTotal> GetMonthlyMealTotalByUser(string Name, string month, string year)
        {
            var result = context.MonthlyMealTotal.Where(a => a.Name == Name).ToList();
            return result;
        }
        public void InsertTotalMeal(List<MonthlyMealTotal> monthlyMealTotal)
        {
            foreach (var item in monthlyMealTotal)
            {
                context.MonthlyMealTotal.Add(item);
            }
            context.SaveChanges();
        }
    }
}
