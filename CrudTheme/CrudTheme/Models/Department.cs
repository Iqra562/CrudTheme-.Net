using System.ComponentModel.DataAnnotations;

namespace CrudTheme.Models
{
    public class Department
    {
        [Key]
        int DepartmentId { get; set; }
        [Required]
        string DepartmentName { get; set; }
       


    }
}
