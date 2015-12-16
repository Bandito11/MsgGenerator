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
using Windows.Storage;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace MsgGenerator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private  void  Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();            
            int a =1, b =10, message = rnd.Next(a, b); 
            if (message == 1)            
                TextBox1.Text = "The will to win, the desire to succeed, the urge to reach your full potential... these are the keys that will unlock the door to personal excellence.";
            else if(message == 2)
                TextBox1.Text = "Choose a job you love, and you will never have to work a day in your life.";
            else if (message == 3)
                TextBox1.Text = "Music is a moral law. It gives soul to the universe, wings to the mind, flight to the imagination, and charm and gaiety to life and to everything.";
            else if (message == 4)
                TextBox1.Text = "To know, is to know that you know nothing. That is the meaning of true knowledge.";
            else if (message == 6)
                TextBox1.Text = "It is not living that matters, but living rightly.";
            else if (message == 7)
                TextBox1.Text = "Change will not come if we wait for some other person or some other time. We are the ones we've been waiting for. We are the change that we seek.";
            else if (message == 8)
                TextBox1.Text = "We are what we repeatedly do. Excellence, then, is not an act, but a habit.";
            else if (message == 9)
                TextBox1.Text = "Success is a lousy teacher. It seduces smart people into thinking they can't lose.";
            else if (message == 10)
                TextBox1.Text = "Everyone needs a coach. It doesn't matter whether you're a basketball player, a tennis player, a gymnast or a bridge player.";

        }


        private void textblock_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

              
    }
}
