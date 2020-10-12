using System;

namespace Masiv.Model.Models
{
    public class RouletteBets
    {
        public int Id { get; set; }
        public int Color { get; set; }
        public int Number { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}