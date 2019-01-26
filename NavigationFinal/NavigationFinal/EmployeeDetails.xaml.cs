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
	public partial class EmployeeDetails : ContentPage
	{
		public EmployeeDetails ()
		{
			InitializeComponent ();
            this.Title = "Employee Details";
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {

            var personalItem = (Employee)BindingContext;
            await App.Database.SaveEmployeeAsync(personalItem);
            await Navigation.PopAsync();

        }
    }
}