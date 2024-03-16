using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class Food
    {
        [Key]
        public int Id_Food { get; set; }

        [Required(ErrorMessage = " ")]
        public string? Name_Food { get; set; }

        [Required(ErrorMessage = " ")]
        public string? Image_Location { get; set; }

        [Required(ErrorMessage = " ")]
        public int? Id_Category { get; set; }
       
        [ForeignKey("Id_Category")]
        public Category? Category { get; set; }

        public List<FoodSize> FoodSizes { get; set; }

        public Food()
        {

        }
    }
}
