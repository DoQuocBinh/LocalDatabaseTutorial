using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalDatabaseTutorial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(String param)
        {
            InitializeComponent();
            myLable.Text = $"Hi {param}";
          
        }

        private async void  Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        
        }
    }
}