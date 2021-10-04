using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorldSkills
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new TourPage());
            Manager.MainFrame = MainFrame;
            LoadPic();
        }

        private void Btn_Back(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
        private void MainFrame_Render(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
                BtnBack.Visibility = Visibility.Visible;
            else
                BtnBack.Visibility = Visibility.Hidden;
        }
        private void LoadPic()
        {
            var link = @"C:\Users\23\Desktop\Новая папка";

            var images = Directory.GetFiles(link);
            int i = 0;
            foreach (var item in TourBaseEntities.GetContext().Tour.ToList())
            {

                item.ImagePreview = File.ReadAllBytes(images.ToArray()[i]);
                i++;

                TourBaseEntities.GetContext().SaveChanges();

            }

        }
    }
}
