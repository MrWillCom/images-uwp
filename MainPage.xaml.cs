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

namespace Images
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter.GetType().Equals(typeof(string))) {
                SetImage(e.Parameter.ToString());
            }
        }

        public void SetImage(string path)
        {
            Windows.UI.Xaml.Media.Imaging.BitmapImage newImg = new Windows.UI.Xaml.Media.Imaging.BitmapImage();
            newImg.UriSource = new Uri(mainImg.BaseUri, path);
            mainImg.Source = newImg;
        }
    }
}
