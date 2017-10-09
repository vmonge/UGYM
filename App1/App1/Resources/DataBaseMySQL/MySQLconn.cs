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

        string ust;
        string pass;

        public MySQLconn(string usr, string pass)
        {
            usr = User;
            pass = Password;
        }

        MySqlConnectionStringBuilder Builder = new MySqlConnectionStringBuilder();

        public bool TryConnection(out string Error)
        {
            Builder.Server = "13.90.252.180";
            Builder.Database = "ugym_mobile";
            Builder.UserID = "ugym_mobile";
            Builder.Password = "$3c_truecontrol";

            try
            {
                MySqlConnection ms = new MySqlConnection(Builder.ToString());
                ms.Open();
                Error = "";
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.ToString;
                return false;
            }
        }

    }
}