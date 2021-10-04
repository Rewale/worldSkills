using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using Xamarin.Forms;

namespace ToursApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var client = new WebClient();
            var response = client.DownloadString("http://10.0.2.2:59862/api/Hotels");
            
            LViewHotel.ItemsSource = JsonConvert.DeserializeObject<List<Hotel>>(response);
            //System.Console.WriteLine(LViewHotel.SelectedItem.ToString());
        }

        private void LViewHotel_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            Navigation.PushAsync(new CommentPage(((sender as ListView).SelectedItem as Hotel).Id));
            
        }
    }
}
