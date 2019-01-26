using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigationFinal.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationFinal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListDetailsPage : ContentPage
	{
		public ListDetailsPage (Contacts contacts)
		{
			InitializeComponent ();

            BindingContext = contacts;
		}
	}
}