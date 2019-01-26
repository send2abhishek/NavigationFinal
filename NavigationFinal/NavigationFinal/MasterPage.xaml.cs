using NavigationFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationFinal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
		public MasterPage ()
		{
			InitializeComponent ();

            var listItems = new List<Contacts>
            {
                new Contacts{FirstName ="Abhishek Aryan",SecName="its abhishek",Image="icons8_user.png" },
                new Contacts{FirstName ="Asish",SecName="its Asish",Image="icons8_user.png" },
                new Contacts{FirstName ="Shekhar",SecName="its Shekhar",Image="icons8_user.png" }
            };

            myList.ItemsSource = listItems;

        }

        private async void MyList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            

            var contact = e.SelectedItem as Contacts;

            await Navigation.PushAsync(new ListDetailsPage(contact));

            myList.SelectedItem = null;
        }
    }
}