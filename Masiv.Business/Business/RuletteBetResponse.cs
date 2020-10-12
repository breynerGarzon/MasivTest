using System;
using System.Collections.Generic;
using System.Linq;
using Masiv.Model.Models;
using Masiv.Data.Util;

namespace Masiv.Business.Business
{
    public class RuletteBetResponse
    {
        private BettingSummary Summary { get; set; }
        private readonly IEnumerable<RouletteBets> DataBets;
        public RuletteBetResponse(IEnumerable<RouletteBets> dataBets)
        {
            this.DataBets = dataBets;
            this.Summary = new BettingSummary() { CountOfBets = dataBets.Count(), TotalValueOfBets = dataBets.Sum(bet => bet.Amount) };
            this.GetNumberWinner();
            this.GetColorWinner();
        }

        private void GetNumberWinner()
        {
            Random generateWinnerNumber = new Random();
            int numberWinner = generateWinnerNumber.Next(DataBusiness.MINIMUMBETNUMBER, DataBusiness.MAXIMUMBETNUMBER);
            this.Summary.NumberWinner = numberWinner;
            var winners = this.DataBets.Where(bet => bet.Number == numberWinner)
                                        .Select(winnerTempo => new ViewRouletteBets()
                                        {
                                            BetAmount = winnerTempo.Amount,
                                            AmountWonOnTheBet = winnerTempo.Amount * DataBusiness.BETMULTIPLAYERBYNUMBER
                                        });
            if (winners.Count() != 0)
            {
                this.Summary.WinnersInformationByNumber = winners;
            }
            else
            {
                this.Summary.Message = "No hay ganadores";
            }
        }

        private void GetColorWinner()
        {
            Random generateWinnerNumber = new Random();
            int colorWinner = generateWinnerNumber.Next(DataBusiness.MINIMUNCOLOR, DataBusiness.MAXIMUMCOLOR);
            var winners = this.DataBets.Where(bet => bet.Color == colorWinner)
                                        .Select(winnerTempo => new ViewRouletteBets()
                                        {
                                            BetAmount = winnerTempo.Amount,
                                            AmountWonOnTheBet = winnerTempo.Amount * DataBusiness.BETMULTIPLAYERBYCOLOR
                                        });
            this.Summary.WinnersInformationByColor = winners;
            this.Summary.ColorWinner = ((Colors)colorWinner).ToString();
        }

        public BettingSummary GetSumaryOfBets()
        {
            return Summary;
        }
    }
}