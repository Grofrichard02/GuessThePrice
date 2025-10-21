using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using GuessThePrice.Model;

namespace GuessThePrice.ViewModel
{
    public class GuessThePriceViewModel : ViewModelBase
    {
        public GuessThePriceModel _model;
        private int _minimumPrice;
        private int _maximumPrice;
        private int _opPrice;
        private int _playerPrice;
        private string _realPrice;
        private string _winnertext;

        public int PlayerPrice
        {
            get
            {
                return _playerPrice;
            }
            set
            {
                if (_playerPrice != value)
                {
                    _playerPrice = value;
                    OnPropertyChanged(nameof(PlayerPrice));
                }
            }
        }
        public int OpPrice
        {
            get
            {
                return _opPrice;
            }
            set
            {
                if (_opPrice != value)
                { 
                    _opPrice= value;
                    OnPropertyChanged(nameof(OpPrice));
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
                    OnPropertyChanged(nameof(MinimumPrice));
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
                    OnPropertyChanged(nameof(MaximumPrice));
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
                    OnPropertyChanged(nameof(RealPrice));
                }
            }
        }
        public string WinnerText
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
                    OnPropertyChanged(nameof(WinnerText));
                }
            }
        }
        public RelayCommand NextRoundCommand { get; set; }
        public RelayCommand PlayerGuessCommand { get; set; }
        public GuessThePriceViewModel(GuessThePriceModel model)
        { 

            _model=model;
            NextRoundCommand = new RelayCommand(_model.NextRound);
            _model.SetUpNextRound += InviteModel;
            _model.AfterGuess += AfterGuessInvite;
            _model.NextRound();
            
        }

        private void AfterGuessInvite(object? sender, GuessThePriceEventArgs e)
        {
            
        }

        private void InviteModel(object? sender, GuessThePriceEventArgs e)
        {
        }

        public void setPrices(GuessThePriceEventArgs g)
        {
            MinimumPrice = g.MinimumPrice;
            MaximumPrice = g.MaximumPrice;
            RealPrice = g.RealPrice;
            _opPrice=g.OpPriceGuess;
            PlayerPrice = g.PlayerPriceGuess;
            WinnerText=g.WInnerTExt;
        }
    }
}

