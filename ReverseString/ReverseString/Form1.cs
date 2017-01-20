using System;
using System.Text;
using System.Windows.Forms;

namespace ReverseString
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			string startingText = textBox1.Text;

			StringBuilder builder = new StringBuilder();

			for ( int index = 0; index < startingText.Length; index++ )
			{
				builder.Append( startingText.Substring( startingText.Length - 1 - index, 1 ) );
			}

			label1.Text = builder.ToString();

		}
	}
}
