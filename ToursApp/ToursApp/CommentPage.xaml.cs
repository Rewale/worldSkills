using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

namespace ToursApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommentPage : ContentPage
    {
        private int HotelID;
        public HotelComment HotelComment { get; set; } = new HotelComment();
        
        public CommentPage(int HotelID)
        {
            InitializeComponent();

            this.HotelID = HotelID;
            HotelComment.HotelId = HotelID;
            BindingContext = this;

            UpdateComm();

        }
        private void UpdateComm()
        {
            var web = new WebClient();

            var response = web.DownloadString($"http://10.0.2.2:59862/api/getHotelComments?hotelId={HotelID}");
            LSviewCom.ItemsSource = JsonConvert.DeserializeObject<List<HotelComment>>(response);
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void SenBtn_Clicked(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://10.0.2.2:59862/api/HotelComments", JsonConvert.SerializeObject(HotelComment));
            UpdateComm();
        }
    }
}