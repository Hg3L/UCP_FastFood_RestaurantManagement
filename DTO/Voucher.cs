using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    public class Voucher
    {
        [Key]
        public int Id_Voucher { get; set; } 

        [Required]
        public string Voucher_Code { get; set; }

        [Required]
        public decimal Discount_Price { get; set; }

        [Required]
        public decimal Min_Price { get; set; }

        [Required]
        public DateTime Begin_Day { get; set; }

        [Required]
        public DateTime End_Day { get; set; }

        public int Id_Account { get; set; }

        [ForeignKey("Id_Account")]
        public UserAccount user { get; set; }
    }
}
