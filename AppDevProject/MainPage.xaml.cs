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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AppDevProject
{
    
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        static public int choice = 0;
        static public int choice2 = 0;
        public MainPage()
        {
            this.InitializeComponent();
        }

     
         private void U16_btn_Click(object sender, RoutedEventArgs e)
        {
            choice = 1;
            choice2 = 1;
            Frame.Navigate(typeof(FixturesAndResults));
        }
        private void Minor_btn_Click(object sender, RoutedEventArgs e)
        {
            choice = 2;
            choice2 = 2;
            Frame.Navigate(typeof(FixturesAndResults));
        }
        private void U21_btn_Click(object sender, RoutedEventArgs e)
        {

            choice = 3;
            choice2 = 3;
            Frame.Navigate(typeof(FixturesAndResults));
        }
        private void Junior_btn_Click(object sender, RoutedEventArgs e)
        {
            choice = 4;
            choice2 = 4;
            Frame.Navigate(typeof(FixturesAndResults));
        }
        private void Inter_btn_Click(object sender, RoutedEventArgs e)
        {
            choice = 5;
            choice2 = 5;
            Frame.Navigate(typeof(FixturesAndResults));
        }
        private void Senior_btn_Click(object sender, RoutedEventArgs e)
        {
            choice = 6;
            choice2 = 6;
            Frame.Navigate(typeof(FixturesAndResults));
        }

        
    }
    }

