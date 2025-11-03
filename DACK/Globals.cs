using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACKW
{
    internal class Globals
    {
        public static int GlobaUserID { get; private set; }
      //  public static string GlobaUserID { get; private set; }

        // GlobalInt can be changed only via this method
        public static void SetGlobalUserID(int userID)
        {
            GlobaUserID = userID;
        }
        //public static void SetGlobalUserID(string userID)
        //{
        //    GlobaUserID = userID;
        //}
        public static string GlobaStringUserID { get; private set; }

        // GlobalInt can be changed only via this method
        public static void SetGlobaStringlUserID(string userID)
        {
            GlobaStringUserID = userID;
        }

        public static string Type { get; private set; }
        public static void setType(string type)
        {
            Type = type;
        }
    }
}
