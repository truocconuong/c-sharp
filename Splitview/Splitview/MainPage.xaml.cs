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

namespace Splitview
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void ToggleMenu_Click(object sender, RoutedEventArgs e)
        {
            this.splitview.IsPaneOpen = !this.splitview.IsPaneOpen;
        }
        private void ChangeContent(object sender,RoutedEventArgs e)
        {
            var hypelink = sender as HyperlinkButton;
            if(hypelink != null)
            {
                switch (hypelink.Tag)
                {
                    case "Register":
                        this.MainContent.Navigate(typeof(Register));
                        break;
                    case "Login":
                        this.MainContent.Navigate(typeof(Login));
                        break;
                }
            }
        }
    }
}
