using System.ComponentModel.DataAnnotations;

namespace HostelManagementSystem.Entity
{
    public class Member
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
