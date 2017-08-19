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
using App1.Resources.Model;
using Java.Lang;

namespace App1.Resources
{
    public class ViewHolder : Java.Lang.Object
    {
        public TextView TxtDia { get; set; }

        public TextView TxtNombre { get; set; }

    }

    public class ListViewAdapter:BaseAdapter
    {
        private Activity activity;

        private List<Rutina> listRutina;

        public ListViewAdapter(Activity activity, List<Rutina> listRutina)
        {
            this.activity = activity;
            this.listRutina = listRutina;
        }

        public override int Count
        {
            get
            {
                return listRutina.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return listRutina[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.list_view_dataTemplate, parent, false);

            var txtDia = view.FindViewById<TextView>(Resource.Id.textView1);
            var txtName = view.FindViewById<TextView>(Resource.Id.textView1);

            txtDia.Text = listRutina[position].Dia;
            txtName.Text = listRutina[position].Nombre;

            return view;
        }
    }
}