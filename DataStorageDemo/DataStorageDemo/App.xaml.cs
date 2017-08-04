using DataStorageDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DataStorageDemo
{
	public partial class App : Application
	{
		public App (string displaText)
		{
			InitializeComponent();

            //Intialize the connection and database
            PersonRepository.Initialize(displaText);

            MainPage = new NavigationPage( new DataStorageDemo.MainPage() {
                LocalPath = displaText
            });
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}