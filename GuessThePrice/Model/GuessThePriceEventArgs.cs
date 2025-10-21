using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThePrice.Model
{
    public class GuessThePriceEventArgs
    {
        public int _minimumPrice { get; private set; }
        public int _maximumPrice { get; private set; }
        public string _realPrice { get; private set; }
        public string _winnertext { get; private set; }
        public int _OpGuess { get; private set; }
        public int _playerGuess { get; private set; }
        public int OpPriceGuess
        {
            get
            {
                return _OpGuess;
            }
            set
            {
                if (_OpGuess != value)
                {
                    _OpGuess = value;
                }
            }
        }
        public int MinimumPrice
        {
            get
            {
                return _minimumPrice;
            }
            set
            {
                if (_minimumPrice != value)
                {
                    _minimumPrice = value;
                }
            }
        }
        public int MaximumPrice
        {
            get
            {
                return _maximumPrice;
            }
            set
            {
                if (_maximumPrice != value)
                {
                    _maximumPrice = value;
                }
            }
        }
        public int PlayerPriceGuess
        {
            get
            {
                return _playerGuess;
            }
            set
            {
                if (_playerGuess != value)
                {
                    _playerGuess = value;
                }
            }
        }
        public string RealPrice
        {
            get
            {
                return _realPrice;
            }
            set
            {
                if (_realPrice != value)
                {
                    _realPrice = value;
                }
            }
        }
        public string WInnerTExt
        {
            get
            {
                return _winnertext;
            }
            set
            {
                if (_winnertext != value)
                {
                    _winnertext = value;
                }
            }
        }


        public GuessThePriceEventArgs(int playerPriceGuess,int minimumPrice, int maximumPrice, string winnertext, string realPrice, int opGuess)
        {
            _minimumPrice = minimumPrice;
            _maximumPrice = maximumPrice;
            _realPrice = realPrice;
            _OpGuess = opGuess;
            _playerGuess= playerPriceGuess;
            _winnertext = winnertext;
        }

        public GuessThePriceEventArgs(int minimumPrice, int maximumPrice, int playerPick, int opGuess, string realPrice, string winnertext)
        {
            _minimumPrice = minimumPrice;
            _maximumPrice = maximumPrice;
            _OpGuess = opGuess;
            _realPrice = realPrice;
            _winnertext = winnertext;
        }
    }
}
