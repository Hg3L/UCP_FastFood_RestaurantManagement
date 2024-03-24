using System.Net.NetworkInformation;
using System.Text;

namespace BLL.Common
{
    public class MACAddressDevice
    {
        // Phương thức ghép tất cả các chuỗi địa chỉ MAC của thiết bị
        public string GetMACAddressDevice()
        {
            StringBuilder macAddresses = new StringBuilder();

            // Lấy tất cả các card mạng trên thiết bị
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface nic in nics)
            {
                // Kiểm tra nếu card mạng là loại Ethernet
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    macAddresses.Append(nic.GetPhysicalAddress().ToString());
                }
            }
            return macAddresses.ToString();
        }
    }
}
