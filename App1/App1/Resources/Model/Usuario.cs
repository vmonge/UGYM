using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace App1.Resources.Model
{
    public class Usuario
    {

        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string Email { get; set; }

        public string Pass { get; set; }

        public bool State { get; set; }

    }
}