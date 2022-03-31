using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;


namespace LocalDatabaseTutorial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());

        }
        static Database database;

        //Attribute(Thuoc tinh) Database
        public static Database Database
        {
            get
            {
                //kiem tra neu chua co database thi tao ra mot database ten: people.db3 trong thu muc ma nguoi dung cai Ung dung
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return database;
            }
          
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
