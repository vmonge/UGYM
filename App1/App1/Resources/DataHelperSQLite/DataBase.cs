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
using Android.Util;
using App1.Resources.Model;

namespace UGYM.Resources.DataHelperSQLite
{
    public class DataBase
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public bool CreateDataBase()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "UGYM_DB.db")))
                {
                    connection.CreateTable<Usuario>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLite Exception", ex.Message);
                return false;
            }
        }

        public bool InsertTableUsuario(Usuario usuario)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "UGYM_DB.db")))
                {
                    connection.Insert(usuario);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLite Exception", ex.Message);
                return false;
            }
        }

        public List<Rutina> SelectTableRutina()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "UGYM.db")))
                {
                    return connection.Table<Rutina>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLite Exception", ex.Message);
                return null;
            }
        }

        public bool SelectQueryTableRutina(int Id)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "UGYM.db")))
                {
                    connection.Query<Rutina>("SELECT * FROM Rutina Where Id =?", Id);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLite Exception", ex.Message);
                return false;
            }
        }

        public bool SelectQueryTableUsuario()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "UGYM.db")))
                {
                    int count = Convert.ToInt32(connection.Query<Rutina>("SELECT count(*) FROM User"));
                    if (count == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLite Exception", ex.Message);
                return false;
            }
        }

        public bool DeleteQueryTablaUsuario()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "UGYM.db")))
                {
                    connection.DeleteAll<Usuario>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLite Exception", ex.Message);
                return false;
            }
        }

        public bool SelectQueryStateUsuario()
        {

            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "UGYM.db")))
                {
                    connection.Query<Usuario>("SELECT count(*) FROM table");
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLite Exception", ex.Message);
                return false;
            }
        }
    }
}