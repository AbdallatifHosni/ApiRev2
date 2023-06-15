/*aut generate -- database first*/
/*Code Frist*/
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Models
{
    
    public partial class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }//textchange <input  asp-for="name" value/>
        public string Address { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int Dept { get; set; }
        public Department Department { get; set; }

    }
}
