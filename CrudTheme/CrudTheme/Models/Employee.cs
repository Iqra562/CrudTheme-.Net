using System.ComponentModel.DataAnnotations;

namespace CrudTheme.Models
{
    public enum EmployeeShifts
    {
        Morning,
        Night
    }
    public class Employee: DateEntity
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Shift is required.")]
        public EmployeeShifts Shift { get; set; }


        [Required]
        public int Salary { get; set; }
        [Required]
        public string Image { get; set; }

        public string  City { get; set; }
        [MaxLength(11),Required]
        public string PhoneNumber { get; set; }
        [Range(18, int.MaxValue, ErrorMessage = "Age must be 18 or greater.")]
        public int Age { get; set; }
        public int DeprtmentId { get; set; }
        public Department Department { get; set; }

    }
}
