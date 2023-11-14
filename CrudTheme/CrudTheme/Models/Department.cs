using System.ComponentModel.DataAnnotations;

namespace CrudTheme.Models
{
    public class Department: DateEntity
    {
        [Key]
      public int DepartmentId { get; set; }

        [Required]
       public string DepartmentName { get; set; }
       


    }
}
