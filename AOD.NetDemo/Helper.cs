using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOD.NetDemo
{
    internal class Helper
    {
        public static string ConnStr
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["MSNetDemoDB"].ConnectionString;
            }
        }
    }
}
