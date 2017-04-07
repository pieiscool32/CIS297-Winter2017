using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Gaming.Input;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XBoxOneFirstAttempt
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		private bool GameOver = false;
		private DispatcherTimer timer;
		private bool downward = true;
		private bool leftward = true;
		private bool leftKeyDown = false;
		private bool rightKeyDown = false;
		private bool aKeyDown = false;
		private bool dKeyDown = false;
		private int ballSpeed = 1;
		private int players = 1;

		private Gamepad controller;

		private Random random;

		public MainPage()
		{
			// disable the TV safe display zone to get images to the very edge
			Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetDesiredBoundsMode( Windows.UI.ViewManagement.ApplicationViewBoundsMode.UseCoreWindow );

			this.InitializeComponent();

			// setup game timer
			timer = new DispatcherTimer();
			// add event handler to the Tick event
			timer.Tick += dispatcherTimer_Tick;
			timer.Interval = new TimeSpan( 0, 0, 0, 0, 2 );
			timer.Start();

			random = new Random();

			// ensure keypresses are captured no matter what UI element has the focus
			Window.Current.CoreWindow.KeyDown += KeyDown_Handler;
			Window.Current.CoreWindow.KeyUp += KeyUp_Handler;
			image.Source = new BitmapImage();
			image.Margin = new Thickness();
		}

		protected override void OnNavigatedTo( NavigationEventArgs e )
		{
			switch ((int)e.Parameter)
			{
				case 0:
					players = 0;
					break;
				case 2:
					players = 2;
					break;
				default:
					players = 1;
					break;
			}			
		}

		private void dispatcherTimer_Tick( object sender, object e )
		{
			MovePaddles();

			EnsurePaddleIsInBounds(BottomPaddle);
			EnsurePaddleIsInBounds( TopPaddle );

			if ( Ball.Margin.Top + Ball.Height > LeftWall.Margin.Top + LeftWall.Height || Ball.Margin.Top < LeftWall.Margin.Top )
			{
				GameOver = true;
			}

			if ( GameOver )
			{
				timer.Stop();
				ElementSoundPlayer.Play( ElementSoundKind.GoBack );
				this.Frame.Navigate( typeof( Start ), "Game Over" );
			}

			if ( Ball.Margin.Left == LeftWall.Margin.Left + LeftWall.Width || Ball.Margin.Left + ballSpeed < LeftWall.Margin.Left + LeftWall.Width )
			{
				leftward = false;
				ElementSoundPlayer.Play( ElementSoundKind.Focus );
				Ball.Fill = getRandomColor();
			}

			if ( Ball.Margin.Left + Ball.Width == RightWall.Margin.Left || Ball.Margin.Left + Ball.Width + ballSpeed > RightWall.Margin.Left )
			{
				leftward = true;
				ElementSoundPlayer.Play( ElementSoundKind.Focus );
				Ball.Fill = getRandomColor();
			}

			if ( Ball.Margin.Top + Ball.Height + ballSpeed >= BottomPaddle.Margin.Top && Ball.Margin.Top + Ball.Height < BottomPaddle.Margin.Top
				&& Ball.Margin.Left >= BottomPaddle.Margin.Left
				&& Ball.Margin.Left + Ball.Width <= BottomPaddle.Margin.Left + BottomPaddle.Width )
			{
				ElementSoundPlayer.Play( ElementSoundKind.Focus );
				downward = false;
				
				BottomPaddle.Fill = getRandomColor();
				Ball.Fill = getRandomColor();
			}

			if ( Ball.Margin.Top - ballSpeed < TopPaddle.Margin.Top + TopPaddle.Height && Ball.Margin.Top >= TopPaddle.Margin.Top + TopPaddle.Height
				&& Ball.Margin.Left >= TopPaddle.Margin.Left
				&& Ball.Margin.Left + Ball.Width <= TopPaddle.Margin.Left + TopPaddle.Width )
			{
				ElementSoundPlayer.Play( ElementSoundKind.Focus );
				downward = true;
				TopPaddle.Fill = getRandomColor();
				Ball.Fill = getRandomColor();
			}

			double left = Ball.Margin.Left;
			double top = Ball.Margin.Top;

			if ( downward )
			{
				top += ballSpeed;
			}
			else
			{
				top -= ballSpeed;
			}

			if ( leftward )
			{
				left -= ballSpeed;
			}
			else
			{
				left += ballSpeed;
			}

			Ball.Margin = new Thickness( left, top, 0, 0 );
		}

		private SolidColorBrush getRandomColor()
		{
			return new SolidColorBrush( Color.FromArgb( 255, (byte)random.Next( 255 ), (byte)random.Next( 255 ), (byte)random.Next( 255 ) ) );
		}

		private void MovePaddles()
		{
			if ( players == 0 )
			{
				ComputerMovePaddle(TopPaddle);
				ComputerMovePaddle(BottomPaddle);
			}

			else if ( Gamepad.Gamepads.Count > 0 )
			{
				controller = Gamepad.Gamepads.First();

				var reading = controller.GetCurrentReading();
				if ( reading.LeftThumbstickX < -.1 || reading.LeftThumbstickX > 0.1 )
				{
					BottomPaddle.Margin = new Thickness( BottomPaddle.Margin.Left + 10 * reading.LeftThumbstickX, BottomPaddle.Margin.Top, 0, 0 );
				}
				if ( players == 2 )
				{
					if ( reading.RightThumbstickX < -.1 || reading.RightThumbstickX > 0.1 )
					{
						TopPaddle.Margin = new Thickness( TopPaddle.Margin.Left + 10 * reading.RightThumbstickX, TopPaddle.Margin.Top, 0, 0 );
					}
				}
				else
				{
					ComputerMovePaddle( TopPaddle );
				}
				if ( reading.Buttons.HasFlag( GamepadButtons.A ) )
				{
					ballSpeed++;
				}
				if ( reading.Buttons.HasFlag( GamepadButtons.B ) )
				{
					ballSpeed--;
				}
			}
			else
			{
				if ( players == 2 )
				{
					if ( leftKeyDown )
					{
						TopPaddle.Margin = new Thickness( TopPaddle.Margin.Left - 5 * ballSpeed, TopPaddle.Margin.Top, 0, 0 );
					}
					if ( rightKeyDown )
					{
						TopPaddle.Margin = new Thickness( TopPaddle.Margin.Left + 5 * ballSpeed, TopPaddle.Margin.Top, 0, 0 );
					}
				}
				else
				{
					ComputerMovePaddle( TopPaddle );
				}
				if ( aKeyDown )
				{
					BottomPaddle.Margin = new Thickness( BottomPaddle.Margin.Left - 5 * ballSpeed, BottomPaddle.Margin.Top, 0, 0 );
				}
				if ( dKeyDown )
				{
					BottomPaddle.Margin = new Thickness( BottomPaddle.Margin.Left + 5 * ballSpeed, BottomPaddle.Margin.Top, 0, 0 );
				}
			}
		}

		private void ComputerMovePaddle( Rectangle paddle )
		{
			paddle.Margin = new Thickness( Ball.Margin.Left - ( paddle.Width / 2 ), paddle.Margin.Top, 0, 0 );
		}

		private void EnsurePaddleIsInBounds(Rectangle paddle)
		{
			if ( paddle.Margin.Left < LeftWall.Margin.Left )
			{
				paddle.Margin = new Thickness( LeftWall.Margin.Left, paddle.Margin.Top, 0, 0 );
			}
			else if ( paddle.Margin.Left + paddle.Width > RightWall.Margin.Left )
			{
				paddle.Margin = new Thickness( RightWall.Margin.Left - paddle.Width, paddle.Margin.Top, 0, 0 );
			}
		}

		private void KeyDown_Handler( Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs e )
		{
			if ( e.VirtualKey == Windows.System.VirtualKey.Left )
			{
				leftKeyDown = true;
			}
			else if ( e.VirtualKey == Windows.System.VirtualKey.Right )
			{
				rightKeyDown = true;
			}
			else if ( e.VirtualKey == Windows.System.VirtualKey.A )
			{
				aKeyDown = true;
			}
			else if ( e.VirtualKey == Windows.System.VirtualKey.D )
			{
				dKeyDown = true;
			}
			else if ( e.VirtualKey == Windows.System.VirtualKey.Space )
			{
				ballSpeed++;
			}
			else if ( e.VirtualKey == Windows.System.VirtualKey.Shift )
			{
				ballSpeed--;
			}
		}

		private void KeyUp_Handler( Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs e )
		{
			if ( e.VirtualKey == Windows.System.VirtualKey.Left )
			{
				leftKeyDown = false;
			}
			else if ( e.VirtualKey == Windows.System.VirtualKey.Right )
			{
				rightKeyDown = false;
			}
			else if ( e.VirtualKey == Windows.System.VirtualKey.A )
			{
				aKeyDown = false;
			}
			else if ( e.VirtualKey == Windows.System.VirtualKey.D )
			{
				dKeyDown = false;
			}

		}
	}
}
