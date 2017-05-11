using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Windows.Forms;
namespace KGC_client
{
    class getID
    {

        /// <summary>
        /// 取机器名
        /// </summary>
        /// <returns></returns>
        public string GethostName()
        {
            return System.Net.Dns.GetHostName();
        }

        /// <summary>
        /// 获取网卡硬件地址
        /// </summary>
        /// <returns></returns>
        public static string GetMoAddress()
        {
            string MoAddress = " ";
            using (ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                ManagementObjectCollection moc2 = mc.GetInstances();
                foreach (ManagementObject mo in moc2)
                {
                    //if ((bool)mo["IPEnabled"] == true)
                    MoAddress = mo["MacAddress"].ToString();
                    mo.Dispose();
                }
            }
            return MoAddress.ToString();
        }
        /// <summary>
        /// 获取CPU序列号
        /// </summary>
        /// <returns></returns>
        public string cpuidstr()
        {

            ManagementClass mc = new ManagementClass("Win32_Processor");

            ManagementObjectCollection moc = mc.GetInstances();

            string strID = null;

            foreach (ManagementObject mo in moc)
            {

                strID = mo.Properties["ProcessorId"].Value.ToString();

                break;

            }

            return strID;

        }
        /// <summary>
        /// 获取硬盘序列号
        /// </summary>
        /// <returns></returns>
        public string hdstr()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
                string strHardDiskID = null;
                foreach (ManagementObject mo in searcher.Get())
                {
                    strHardDiskID = mo["SerialNumber"].ToString().Trim();
                    break;
                }
                return strHardDiskID;
            }
            catch
            {
                return "";
            }

        }
    }
}
