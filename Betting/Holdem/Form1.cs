using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Betting;

namespace Holdem
{
	public partial class Form1 : Form
	{
		private Round round;
		public Form1()
		{
			InitializeComponent();
		}

		private void dealButton_Click( object sender, EventArgs e )
		{
			dealButton.Enabled = false;
			round = new Round( new RandomNumberGenerator() );
			updateLabels();
			dealButton.Enabled = true;
		}

		private void updateLabels()
		{
			shared1Label.Text = round.shared.Cards[ 0 ].ToString();
			shared2Label.Text = round.shared.Cards[ 1 ].ToString();
			shared3Label.Text = round.shared.Cards[ 2 ].ToString();
			shared4Label.Text = round.shared.Cards[ 3 ].ToString();
			shared5Label.Text = round.shared.Cards[ 4 ].ToString();

			mine1.Text = round.player.First.ToString();
			mine2.Text = round.player.Second.ToString();

			computer1.Text = round.computer.First.ToString();
			computer2.Text = round.computer.Second.ToString();

			PokerHand playersBestHand = round.player.GetBestHand( round.shared );
			playerBest.Text = $"Best Hand: {playersBestHand.ToString()} - {playersBestHand.GetHandRank().ToString()} - Odds of Winning: {round.player.GetOddsOfWinning(round.shared)}";

			PokerHand computersBestHand = round.computer.GetBestHand( round.shared );
			computerBest.Text = $"Best Hand: {computersBestHand.ToString()} - {computersBestHand.GetHandRank().ToString()} - Odds of Winning: {round.computer.GetOddsOfWinning( round.shared )}";
		}

	}
}
