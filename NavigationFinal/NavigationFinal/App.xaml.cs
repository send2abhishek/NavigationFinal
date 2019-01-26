using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NavigationFinal
{
    public partial class App : Application
    {
        private const string TitleKey = "Name";
        private const string NotificationEnable = "NotificationEnable";
        static EmployeeDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TabbedViewPage());
        }

        public static EmployeeDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new EmployeeDatabase(DependencyService.Get<ILocalFileHelper>()
                        .getLocalFilePath("Employee.db1"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public string Title
        {
            get
            {
                if (Properties.ContainsKey(TitleKey))
                    return Properties[TitleKey].ToString();
                return "";
            }

            set
            {
                Properties[TitleKey] = value;
            }
        }

        public bool NotificationEnabled
        {

            get
            {
                if (Properties.ContainsKey(NotificationEnable))
                    return (bool)Properties[NotificationEnable];
                return false;
            }
            set
            {
                Properties[NotificationEnable] = value;
            }
        }
    }
}
