using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
	public partial class Form1 : Form
	{
		private List<int> ints;
		private Random random;

		public Form1()
		{
			InitializeComponent();
			random = new Random();
		}

		private void generateEvens_Click( object sender, EventArgs e )
		{
			ints = new List<int>();
			for ( int count = 0; count < 100; count++ )
			{
				ints.Add( random.Next( 1, 10000 ) );
			}

			var evens = from number in ints
						where number % 2 == 0
						orderby number
						select number;
			evensLabel.Text = "";
			foreach ( var number in evens )
			{
				evensLabel.Text += number.ToString() + "\n";
			}

			var odds = ints
				.Where( number => number % 2 == 1 )
				.OrderByDescending( number => number );

			oddsLabel.Text = "";
			foreach ( var number in odds )
			{
				oddsLabel.Text += number.ToString() + "\n";
			}
		}
	}
}
