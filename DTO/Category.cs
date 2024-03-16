using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class Category
    {
        [Key]
        public int Id_Category { get; set; }

        [Required(ErrorMessage = " ")]
        public string? Name_Category { get; set; }

        [Required(ErrorMessage = " ")]
        public string? Image_Location { get; set; }

        public Category() { }
    }
}
