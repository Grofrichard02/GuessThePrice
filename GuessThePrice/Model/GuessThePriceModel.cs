using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GuessThePrice.Model
{
    public class GuessThePriceModel
    {

        private int playerpoints { get; }
        private int oppoints { get;}
        private int rounds { get; }
        public int _minimumPrice { get; private set; }
        public int _maximumPrice { get; private set; }
        public int _playerPick { get; private set; }
        public int _OpGuess { get; private set; }
        public string _realPrice { get; private set; }
        public string _winnertext { get; private set; }
        public Random Rand;

   
        public GuessThePriceModel(GuessThePriceEventArgs e)
        {
            _minimumPrice = e.MinimumPrice;
            _maximumPrice = e.MaximumPrice;
            _realPrice = e.RealPrice;
            Rand = new Random();
        }


        public event EventHandler<GuessThePriceEventArgs> SetUpNextRound;
        public event EventHandler<GuessThePriceEventArgs> AfterGuess;
        public void AfterPlayerGuess(int playerGuess)
        {
            if (playerGuess < Convert.ToInt32(_realPrice) && _OpGuess < Convert.ToInt32(_realPrice))
            {
                int ownPlayerscore = Convert.ToInt32(_realPrice) -playerGuess;
                int enemyPlayerScore = Convert.ToInt32(_realPrice)-_OpGuess;
                if (enemyPlayerScore < ownPlayerscore)
                {
                    MessageBox.Show("Az enemy nyert bocsi");
                }
                else {
                    MessageBox.Show("Nyertél!");
                }
                AfterGuess.Invoke(this, new GuessThePriceEventArgs(_minimumPrice, _maximumPrice, _playerPick, _OpGuess, _realPrice, _winnertext));
            }
            if (playerGuess > Convert.ToInt32(_realPrice) && _OpGuess > Convert.ToInt32(_realPrice))    
            { MessageBox.Show("Senki se nyert."); }
            AfterGuess.Invoke(this, new GuessThePriceEventArgs(_minimumPrice, _maximumPrice, _playerPick, _OpGuess, _realPrice, _winnertext));

            if (playerGuess < Convert.ToInt32(_realPrice) && _OpGuess > Convert.ToInt32(_realPrice))
            { MessageBox.Show("NYERTÉL!"); }
            else
            {
                MessageBox.Show("Az enemy nyert bocsi");
            }
            AfterGuess.Invoke(this, new GuessThePriceEventArgs(_minimumPrice, _maximumPrice, _playerPick, _OpGuess, _realPrice, _winnertext));


        }
        public void NextRound()
        {
            _minimumPrice = Rand.Next(0, 201);
            _maximumPrice = Rand.Next(900, 1201);
            _realPrice = "????";
            _winnertext = "";
            _realPrice = Rand.Next(_minimumPrice, _maximumPrice).ToString();
            _OpGuess = Rand.Next(_minimumPrice, _maximumPrice);
            SetUpNextRound.Invoke(this, new GuessThePriceEventArgs(_minimumPrice, _maximumPrice, _playerPick, _OpGuess, _realPrice, _winnertext));


        }
    }
}
