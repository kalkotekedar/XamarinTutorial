using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataStorageDemo
{
    public partial class MainPage : ContentPage
    {
        public string LocalPath
        {
            get { return pathLocation.Text; }

            set { pathLocation.Text = value; }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenSqliteDemo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SQLitePage());
        }
    }
}
