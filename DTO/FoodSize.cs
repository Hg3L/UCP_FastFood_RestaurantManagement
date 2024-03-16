using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class FoodSize
    {
        [Key]
        public int Id_Size { get; set; }

        [Required(ErrorMessage = " ")]
        public string? Size_Name { get; set; }

        [Required(ErrorMessage = " ")]
        public decimal? Price_Size { get; set; }

        public int Id_Food { get; set; }

        [ForeignKey("Id_Food")]
        public Food Food { get; set; }

        public FoodSize() { }
    }
}
