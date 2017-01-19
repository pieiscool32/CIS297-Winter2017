using System;
using System.Windows.Forms;

namespace GuessingGame
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			int usersGuess;
			Int32.TryParse( textBox1.Text, out usersGuess );
			if ( usersGuess == 0 )
			{
				label1.Text = "Please enter a number!";
			}
			else if ( usersGuess == 42 )
			{
				label1.Text = "You guessed it!";
			}
			else if ( usersGuess > 42 )
			{
				label1.Text = "Too high!";
			}
			else
			{
				label1.Text = "Too low!";
			}
		}
	}
}
