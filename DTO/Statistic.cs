using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class Statistic
    {
        [Key]
        public int Ordinal { get; set; }

        public DateTime Income_Date { get; set; }

        public decimal Total_Income { get; set; }

        public Statistic() { }
    }
}
