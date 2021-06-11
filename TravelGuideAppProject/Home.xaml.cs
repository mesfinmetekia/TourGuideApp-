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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TravelGuideAppProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
        }
    private void btn1_Lalibela(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lalibela_Page));
        }

    private void btn1_Axum(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Axum_Page));
        }

    private void btn1_Gondar(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Gondar_Page));
        }

    private void btn1_DebreDamo(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DebreDamo_Page));
        }

    private void btn1_SimienMountain(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SimienMountain_Page));
        }

    private void btn1_BlueNile(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BlueNile_Page));
        }

    private void btn1_BaleMountain(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BaleMountain_Page));
        }

    private void btn1_DanakilDepression(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DanakilDepression_Page));
        }

    private void btn1_HararWall(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HararWall_Page));
        }

    private void btn1_NechSar(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(NechSar_Page));
        }
    }
}
