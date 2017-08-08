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
        public SQLitePage()
        {
            InitializeComponent();
        }

        public async void OnNewButtonClickedAsync(object sender, EventArgs args)
        {
            //statusMessage.Text = string.Empty;
            //PersonRepository.Instance.AddNewPerson(NewPerson.Text);
            //NewPerson.Text = "";
            //statusMessage.Text = PersonRepository.Instance.StatusMessage;

            /** Async call**/
            statusMessage.Text = string.Empty;
            await PersonRepository.Instance.AddPersonAsync(NewPerson.Text);
            statusMessage.Text = PersonRepository.Instance.StatusMessage;
            NewPerson.Text = "";
        }

        public async void OnGetButtonClickedAsync(object sender, EventArgs args)
        {
            //statusMessage.Text = string.Empty;
            //var people = PersonRepository.Instance.GetAllPeople();
            //PersonList.ItemsSource = people;

            /** Async call**/
            statusMessage.Text = string.Empty;
            var persons = await PersonRepository.Instance.GetAllPersonAsync();
            PersonList.ItemsSource = persons;
        }
    }
}