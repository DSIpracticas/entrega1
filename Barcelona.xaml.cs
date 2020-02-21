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

namespace Blest_Fernandez
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Barcelona : Page
    {
        public Barcelona()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled; //Guarda los datos de navegación
        }

        private void madridButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));

        }

        private void bilbaoButtom_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Bilbao));

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            On_BackRequested();
        }
        // Handles system-level BackRequested events and page-level back button Click events
        private bool On_BackRequested()
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
                return true;
            }
            return false;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            botonAtras.Visibility = Visibility.Visible;
            barcelonaRadio.IsChecked = true;
        }

    }
}
