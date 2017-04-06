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

namespace CzyJestesSzczesliwy
{
    using Windows.UI.Popups;

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

        DispatcherTimer timer = new DispatcherTimer();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            timer.Tick += timer_Tick;
            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Start();
            CheckHappiness();
        }

        int i = 0;

        void timer_Tick(object sender, object e)
        {
            ticker.Text = "Chwila nr " + i++;
        }

        private async void CheckHappiness()
        {
            MessageDialog dialog = new MessageDialog("Czy jesteś szczęśliwy?");
            dialog.Commands.Add(new UICommand("Szczęśliwy i radosny!"));
            dialog.Commands.Add(new UICommand("Smutny jak listopadowa pogoda."));
            dialog.DefaultCommandIndex = 1;
            UICommand result = await dialog.ShowAsync() as UICommand;
            if (result != null && result.Label == "Szczęśliwy i radosny!")
                response.Text = "Użytkownik jest szczęśliwy.";
            else
                response.Text = "Użytkownik jest smutny.";
            timer.Stop();
        }

    }
}
