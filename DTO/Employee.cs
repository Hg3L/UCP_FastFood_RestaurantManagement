using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    public class Employee
    {
        [Key]
        public int ID_Employee { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "Căn cước công dân không hợp lệ")]
        public string Citizen_ID { get; set; }

        [Required(ErrorMessage = " ")]
        public string? Full_Name { get; set; }

        [Required(ErrorMessage = " ")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = " ")]
        public string? Sex { get; set; }

        [Required(ErrorMessage = " ")]
        public string Phone_Number { get; set; }

        [Required(ErrorMessage = " ")]
        public string? PlaceOfOrigin { get; set; }

        public int Id_Account { get; set; }

        [ForeignKey("Id_Account")]
        public UserAccount userAccount { get; set; }  
        
        public Employee()
        {
            
        }
    }
}
