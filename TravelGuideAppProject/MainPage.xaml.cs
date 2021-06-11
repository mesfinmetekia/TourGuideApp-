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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TravelGuideAppProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            BackButton.Visibility = Visibility.Collapsed;
            //MyFrame.Navigate(typeof(Financial));
            //TitleTextBlock.Text = "Financial";
            //Financial.IsSelected = true;

            MyFrame.Navigate(typeof(Home));
            TitleTextBlock.Text = "Home";
            Home.IsSelected = true;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                Home.IsSelected = true;
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Home.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Home));
                TitleTextBlock.Text = "Home";
            }
            else if (About.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(About));
                TitleTextBlock.Text = "About";
            }
            else if (Contact.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Contact));
                TitleTextBlock.Text = "Contact";
            }
            else if (Country.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Country));
                TitleTextBlock.Text = "Country";
            }
            else if (FAQ.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(FAQ));
                TitleTextBlock.Text = "FAQ";
            }
        }
    }
}

