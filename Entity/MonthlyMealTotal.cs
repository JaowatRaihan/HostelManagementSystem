using System;
using System.ComponentModel.DataAnnotations;
namespace HostelManagementSystem.Entity
{
    public class MonthlyMealTotal
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Bazar { get; set; }
        public int RealCost { get; set; }
        public int Balance { get; set; }
        public string Status { get; set; }
        public DateTime? StatusClearDate { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
    }
}
