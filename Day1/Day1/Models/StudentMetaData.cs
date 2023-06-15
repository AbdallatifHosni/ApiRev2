using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Day1.Models
{
    [ModelMetadataType(typeof(StudentMetaData))]
    public partial class Student
    {

        //.......

    }
    //[ModelMetadataType(typeof(StudentMetaData))]
    //public class studentviewMode { }

    public class StudentMetaData
    {

        [Display(Name = "Student NAme")]
        [Required(ErrorMessage = "Name Is Required")]
        [RegularExpression(pattern: "[a-zA-Z]{3,}",
                           ErrorMessage = "name must be char only and more than 2 char")]
        [Remote(action: "NameExist", controller: "Student", ErrorMessage = "Name Already Exist"
            , AdditionalFields = "ID,Age")]//client side validation
        public string Name { get; set; }//textchange <input  asp-for="name" value/>


        //[DataType(DataType.Password)]
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        [Display(Name = "Profile Image")]
        [Required]
        [RegularExpression(@"\w+\.(jpg|png)", ErrorMessage = "Image must contain jpg or png ")]
        public string Image { get; set; }


        [Range(minimum: 20, maximum: 30)]
        [AgeDivby5(info = 5)]
        public int Age { get; set; }
        public int Dept { get; set; }
      

    }
}
