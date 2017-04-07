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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace XBoxOneFirstAttempt
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Start : Page
	{
		public Start()
		{
			this.InitializeComponent();
		}

		private void onePlayer_button_Click( object sender, RoutedEventArgs e )
		{
			this.Frame.Navigate( typeof( MainPage ), 1 );
		}

		private void QuitButton_Click( object sender, RoutedEventArgs e )
		{
			Application.Current.Exit();
		}

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			textBlock.Text = (string)e.Parameter;
		}

		private void two_player_button_Click( object sender, RoutedEventArgs e )
		{
			this.Frame.Navigate( typeof( MainPage ), 2 );
		}

		private void PCvsPCButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainPage), 0);
		}
	}
}
