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
	public partial class TabbedViewPage : TabbedPage
	{
        


        public TabbedViewPage ()
		{
			InitializeComponent ();
            //var app = Application.Current as App;
            //title.Text = app.Title;
            //notoficationEnabled.On = app.NotificationEnabled;
            BindingContext = Application.Current;


        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            label1.Text = e.NewTextValue;
        }

        private void Pick_SelectedIndexChanged(object sender, EventArgs e)
        {


            var items = pick.Items[pick.SelectedIndex];
            DisplayAlert("Slecte Item", items, "Okay");

        }

        //private void OnChange(object sender, ToggledEventArgs e)
        //{

        //    var app = Application.Current as App;
        //    app.Title = title.Text;
        //    app.NotificationEnabled = notoficationEnabled.On;
        //}

        
    }
}