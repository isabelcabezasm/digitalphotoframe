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
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage.Streams;
using System.Threading.Tasks;
using Windows.Storage;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace photoframe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            change_picture();
        }



        async void change_picture() {

            // StorageFile file = await file.

            var file1 = await StorageFile.GetFileFromPathAsync("C:\\Users\\servezas\\Desktop\\myimage.jpeg.jpg");
            var fileStream1 = await file1.OpenAsync(Windows.Storage.FileAccessMode.Read);            
            // Set the image source to the selected bitmap
            BitmapImage bitmapImage1 = new BitmapImage();
            await bitmapImage1.SetSourceAsync(fileStream1);
            
            photo.Source = bitmapImage1;

            
            
        }
    }
}
