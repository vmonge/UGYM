using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;

using MySql.Data.MySqlClient;
using System.Data;

namespace App1.Resources.DataBaseMySQL
{
    

    class MySQLconn
    {

        string usr;
        string pass;

        public MySQLconn()
        {
            usr = string.Empty;
            pass = string.Empty;
        }
    
       MySqlConnectionStringBuilder Builder = new MySqlConnectionStringBuilder();
    
        public bool OpenConn(out string Error)    {
            Builder.Server = "ugymmobile.eastus.cloudapp.azure.com";
            Builder.Database = "ugym_mobile";
            Builder.UserID = "vmonge";
            Builder.Password = "#c_2hU0l!a#462.$";

            try
            {
                MySqlConnection ms = new MySqlConnection(Builder.ToString());
                ms.Open();
                Error = "";
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.ToString();
                return false;
            }
        }

        internal bool TryConnection(out string error)
        {
            throw new NotImplementedException();
        }
    }
}