using System;
using System.Windows.Forms;

namespace MoreExamplesFrom4_9
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
			char[] letters = startingText.ToCharArray();
			for ( int index = 0; index < letters.Length; index++ )
			{
				char letter = letters[ index ];
				int unicodeValue = (int)letter;
				unicodeValue += 5;
				letters[ index ] = (char)unicodeValue;
			}
			label1.Text = new string( letters );
		}
	}
}
