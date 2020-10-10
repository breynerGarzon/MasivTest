using System;
using System.ComponentModel.DataAnnotations;
using Masiv.Model.Models;

namespace Masiv.Model.Views
{
    public class ViewBetRequest
    {
        [Required(ErrorMessage = "El id de la ruleta debe ser suministrado")]
        public int RuletaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Date { get; set; }
        // [Required(ErrorMessage="El id de la ruleta debe ser suministrado")]
        [EnumDataType(typeof(Colors))]
        public Colors ColorApuesta { get; set; }
        [MinLength(0, ErrorMessage = "El número mínimo permitido para las apuestas es 0")]
        public short BetNumber { get; set; }
        [MaxLength(1000, ErrorMessage = "El valor máximo permitido para las apuestas es de $10.000")]
        public decimal BetAmount { get; set; }

        public ViewBetRequest()
        {
            this.Date = DateTime.Now;
        }
    }

}