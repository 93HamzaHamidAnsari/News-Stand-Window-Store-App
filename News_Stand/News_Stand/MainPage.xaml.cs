using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace News_Stand
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            my();
        }
        public async void my()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(250);

            }
            this.Frame.Navigate(typeof(news_stand));
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void open(object sender, RoutedEventArgs e)
        {
            Storyboard1.Begin();
            string xml = @"
<tile>
  <visual>
    <binding template='TileSquarePeekImageAndText01'>
      <image id='1' src='Assets/medium_tile.jpg' alt='alt text'/>
      <text id='1'>Global News(larger text)</text>
      <text id='2'>National News</text>
      <text id='3'>Facts</text>
      <text id='4'>All News</text>
    </binding>  
  </visual>
</tile>
";
            var docc = new XmlDocument();
            docc.LoadXml(xml);
            var notif = new TileNotification(docc);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(notif);


            string xm = @"
<tile>
  <visual>
    <binding template='TileWideImageAndText01'>
      <image id='1' src='Assets/wide_tiles.jpg' alt='alt text'/>
      <text id='1'>News Stand</text>
    </binding>  
  </visual>
</tile>";
            var doc = new XmlDocument();
            doc.LoadXml(xm);
            var not = new TileNotification(doc);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(not);
        }
    }
}
