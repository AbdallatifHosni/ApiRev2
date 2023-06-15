using System.ComponentModel.DataAnnotations;

namespace Day1.Models
{
    public class AgeDivby5Attribute:ValidationAttribute
    {
        public int info { get; set; } = 5;
        //server side only
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Student std=validationContext.ObjectInstance as Student;
            ITIEnitities context = new ITIEnitities();

            int age =int.Parse(value.ToString());
            if (age % info == 0)
            {
                //success
                return ValidationResult.Success;//true
            }
            //faild ==>default message error
            return new ValidationResult($"Age Must Be divided by {info}");
        }
    }
}
