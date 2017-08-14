using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Resources.layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListDay : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListDay()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Dia 1",
                "Dia 2",
                "Dia 3",
                "Dia 4",
                "Dia 5"
            };

            BindingContext = this;
        }

        async void Handle_ItemTapped(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}