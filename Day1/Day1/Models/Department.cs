using System.ComponentModel.DataAnnotations;

namespace Day1.Models
{
    public class Department
    {
        public int Id { get; set; }
        
        [Display(Name ="Dept Name")]//Label
        //[DataType(DataType.EmailAddress)]
        public string Name { get; set; }
        public string  ManagerName { get; set; }
    }
}