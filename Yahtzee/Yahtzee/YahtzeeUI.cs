using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
	public partial class YahtzeeUI : Form
	{
		private PictureBox[] dicePictureBoxes;
		private Bitmap[] dicePictures;
		private RandomNumberGenerator random;
		private YahtzeeDice dice;
		public YahtzeeUI()
		{
			InitializeComponent();
			random = new RandomNumberGenerator();
			dice = new YahtzeeDice( random );
			YahtzeeScoreCard scoreCard = new YahtzeeScoreCard();
			dicePictureBoxes = new PictureBox[5] 
			{
				die1PictureBox,
				die2PictureBox,
				die3PictureBox,
				die4PictureBox,
				die5PictureBox
			};
			dicePictures = new Bitmap[ 6 ] 
			{
				Properties.Resources.die_01,
				Properties.Resources.die_02,
				Properties.Resources.die_03,
				Properties.Resources.die_04,
				Properties.Resources.die_05,
				Properties.Resources.die_06
			};
		}

		private void rollButton_Click( object sender, EventArgs e )
		{
			if ( dice.RollCount <= 2 )
			{
				int[] roll = dice.roll();
				for ( int index = 0; index < 5; index++ )
				{
					dicePictureBoxes[ index ].Image = dicePictures[ roll[ index ] - 1 ];
				}
			}
			else
			{
				RollButton.Enabled = false;
			}
		}
	}
}
