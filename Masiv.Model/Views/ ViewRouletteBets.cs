using System;

namespace Masiv.Model.Views
{
    public class ViewRouletteBets
    {
        public int RouletteId { get; set; }
        public DateTime Date { get; set; }
        public decimal AmountBet { get; set; }
        public int CountBets { get; set; }
    }
}