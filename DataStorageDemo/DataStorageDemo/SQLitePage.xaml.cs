using DataStorageDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataStorageDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SQLitePage : ContentPage
	{
		public SQLitePage ()
		{
			InitializeComponent ();            
		}

        public void OnNewButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = string.Empty;
            PersonRepository.Instance.AddNewPerson(NewPerson.Text);
            NewPerson.Text = "";
            statusMessage.Text = PersonRepository.Instance.StatusMessage;
        }

        public void OnGetButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = string.Empty;
            var people = PersonRepository.Instance.GetAllPeople();
            PersonList.ItemsSource = people;
        }
    }
}