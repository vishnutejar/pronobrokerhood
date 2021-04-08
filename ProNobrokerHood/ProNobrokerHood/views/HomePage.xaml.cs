using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProNobrokerHood.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        ObservableCollection<String> ts { get; set; } = new ObservableCollection<string>();
        public HomePage()
        {
            InitializeComponent();
            ts.Add("");
            ts.Add("");
            ts.Add("");
            ts.Add("");
            ts.Add("");
            ts.Add("");
            ts.Add("");
            ts.Add("");
            lstOfHomePage.ItemsSource = ts;
        }
    }
}