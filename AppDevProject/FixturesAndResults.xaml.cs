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

    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FixturesAndResults : Page
    {
        
        public FixturesAndResults()
        {
            this.InitializeComponent();
        }

        private void Result_btn_Click(object sender, RoutedEventArgs e)
        {
            if (MainPage.choice2 == 1)
            {
                Frame.Navigate(typeof(U16Result));
            }
            if (MainPage.choice2 == 2)
            {
                Frame.Navigate(typeof(minorResult));
            }
            if (MainPage.choice2 == 3)
            {
                Frame.Navigate(typeof(U21Result));
            }
            if (MainPage.choice2 == 4)
            {
                Frame.Navigate(typeof(juniorResult));
            }
            if (MainPage.choice2 == 5)
            {
                Frame.Navigate(typeof(interResult));
            }
            if (MainPage.choice2 == 6)
            {
                Frame.Navigate(typeof(seniorResult));
            }

        }


        private void Home_btn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Fixtures_btn_Click(object sender, RoutedEventArgs e)
        {
            if (MainPage.choice == 1)
            {
                Frame.Navigate(typeof(U16Fixturs));
            }
            else if(MainPage.choice == 2)
            {
                Frame.Navigate(typeof(minor));
            }
            else if (MainPage.choice == 3)
            {
                Frame.Navigate(typeof(U21Fixturs));
            }
            else if (MainPage.choice == 4)
            {
                Frame.Navigate(typeof(juniorFixturs));
            }
            else if (MainPage.choice == 5)
            {
                Frame.Navigate(typeof(InterFixturs));
            }
            else if (MainPage.choice == 6)
            {
                Frame.Navigate(typeof(SeniorFixturs));
            }
        }




    }
}
