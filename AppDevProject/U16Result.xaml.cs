using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class U16Result : Page
    {
        public U16Result()
        {
            this.InitializeComponent();
        }
        private void Home_btn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Team1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TeamLayout));
        }

        private void Team2_Click(object sender, RoutedEventArgs e)
        { 
            Frame.Navigate(typeof(TeamLayout));
        }
  
        private void Team3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TeamLayout));
        }

        private void Team4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TeamLayout));
        }

        private void Team5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TeamLayout));
        }
    }
    }

