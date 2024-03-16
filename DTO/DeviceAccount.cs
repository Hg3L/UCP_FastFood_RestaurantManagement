using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
namespace DTO
{
    public class DeviceAccount
    {
        [Key]
        public int? Id_MAC { get; set; }

        public string? MAC_Address { get; set; }

        public int? Id_Account { get; set; }

        // Navigation property để tham chiếu đến bản ghi trong bảng UserAccount
        [ForeignKey("Id_Account")]
        public UserAccount UserAccount { get; set; }

        public DeviceAccount() { }
    }
}
