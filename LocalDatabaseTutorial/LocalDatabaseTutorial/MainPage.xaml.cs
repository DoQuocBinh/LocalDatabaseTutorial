using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocalDatabaseTutorial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //khi Form: visible voi User
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //Hien thi lai danh sach len list
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Neu Name va Age # null
            if (!string.IsNullOrEmpty( nameEntry.Text)  && !string.IsNullOrWhiteSpace(ageEntry.Text)){
               await App.Database.SavePersonAsync(new Person {
                   Name = nameEntry.Text, Age = int.Parse(ageEntry.Text) });
                
                nameEntry.Text = ageEntry.Text = string.Empty;
                //Hien thi danh sach Person len List: collectionView
                collectionView.ItemsSource = await App.Database.GetPeopleAsync();
            }
            
        }

      async  private void collectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Lay Item ma nguoi dung select
            Person selectedItem = e.CurrentSelection[0] as Person;
            //DisplayAlert("Alert", $"You have selected {selectedItem.Name}", "Ok");
            
            await Navigation.PushAsync(new Page1(selectedItem.Name));
        }
    }
}
