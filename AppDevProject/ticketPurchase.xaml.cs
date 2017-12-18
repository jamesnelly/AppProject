using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppDevProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ticketPurchase : Page
    {

        public ticketPurchase()
        {
            this.InitializeComponent();
        }
        private void Home_btn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private async void Submit_Click(object sender, RoutedEventArgs e)
        {
            String fileName = "Details.txt";
            String name = Name.Text + Environment.NewLine;

            String email = Email.Text + Environment.NewLine;
            
            String address = Address.Text + Environment.NewLine;

            Windows.Storage.StorageFolder storageFolder =
            Windows.Storage.ApplicationData.Current.LocalFolder;

            Windows.Storage.StorageFile sampleFile =
            await storageFolder.CreateFileAsync("Details.txt",
            Windows.Storage.CreationCollisionOption.ReplaceExisting);

            Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile file = await localFolder.GetFileAsync(fileName);

            await FileIO.WriteTextAsync(file, name);
           // await FileIO.AppendTextAsync(file, name);
            await FileIO.AppendTextAsync(file, email);
            await FileIO.AppendTextAsync(file, address);

            Frame.Navigate(typeof(TicketSent));
        }
    }
}
