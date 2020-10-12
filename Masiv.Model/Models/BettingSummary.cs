using System.Collections.Generic;

namespace Masiv.Model.Models
{
    public class BettingSummary
    {
        public decimal TotalValueOfBets  { get; set; }
        public int CountOfBets  { get; set; }
        public int NumberWinner { get; set; }
        public string ColorWinner { get; set; }
        public IEnumerable<ViewRouletteBets> WinnersInformationByNumber { get; set; }
        public IEnumerable<ViewRouletteBets> WinnersInformationByColor { get; set; }
        public string Message { get; set; }
    }
}