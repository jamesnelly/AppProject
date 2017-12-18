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
        //Result button method 
        private void Result_btn_Click(object sender, RoutedEventArgs e)
        {
            //if statement setup to decide to navigate to which result pages
            if (MainPage.choice2 == 1)
            {
                Frame.Navigate(typeof(U16Result));
            }
            else if (MainPage.choice2 == 2)
            {
                Frame.Navigate(typeof(minorResult));
            }
            else if (MainPage.choice2 == 3)
            {
                Frame.Navigate(typeof(U21Result));
            }
            else if (MainPage.choice2 == 4)
            {
                Frame.Navigate(typeof(juniorResult));
            }
            else if (MainPage.choice2 == 5)
            {
                Frame.Navigate(typeof(interResult));
            }
            else if (MainPage.choice2 == 6)
            {
                Frame.Navigate(typeof(seniorResult));
            }

        }
        //home Button method to link you to go back to main page
        private void Home_btn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
        private void Fixtures_btn_Click(object sender, RoutedEventArgs e)
        {     //if statement setup to decide to navigate to which Fixtures pages
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
