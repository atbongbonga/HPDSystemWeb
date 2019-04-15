using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace DAL
{
    public class Settings
    {
        public string UserIP{
            get {
                string hostName = Dns.GetHostName(); 
                return Dns.GetHostByName(hostName).AddressList[0].ToString();
            }
            set { this.UserIP = value; }

        }

    }
    
}
