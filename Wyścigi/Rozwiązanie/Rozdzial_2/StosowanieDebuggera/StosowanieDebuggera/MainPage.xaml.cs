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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StosowanieDebuggera
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

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        /* Dwukrotne kliknięcie przyciku w oknie Designer spowodowało utworzenie 
         * pustej metody Button_Click().
         */


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number = 15;            // umieść punkt przerwania w pierwszym wierszu kodu 
            number = number + 10; 
            number = 36 * 15; 
            number = 12 - (42 / 7); 
            number += 10; 
            number *= 3; 
            number = 71 / 3; 
             
            int count = 0; 
            count++; 
            count--; 
             
            string result = "witam";
            result += " ponownie " + result;
            output.Text = result; 
            result = "wartością jest: " + count;
            result = ""; 
             
            bool yesNo = false; 
            bool anotherBool = true; 
            yesNo = !anotherBool;
        }
    }
}
