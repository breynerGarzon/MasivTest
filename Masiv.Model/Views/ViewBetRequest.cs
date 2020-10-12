using System;
using System.ComponentModel.DataAnnotations;
using Masiv.Data.Util;
using Masiv.Model.Models;

namespace Masiv.Model.Views
{
    public class ViewBetRequest
    {
        [Required(ErrorMessage = "El id de la ruleta debe ser suministrado")]
        public int RouletteId { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        [EnumDataType(typeof(Colors), ErrorMessage = "Los valores permitidos para el colores son 1 para Rojo, 2 para Negro, si no se suministra valor la apuesta se hará por número")]
        public Colors ColorBet { get; set; }
        [Range(0, 36, ErrorMessage = "Los números permitidos para apuestas estan entre 0 y 36")]
        public short BetNumber { get; set; }
        [Range(0, 10000, ErrorMessage = "El valor máximo permitido para las apuestas es de $10.000")]
        public decimal BetAmount { get; set; }
        public string Message { get; set; }

        public ViewBetRequest()
        {
            this.Date = DateTime.Now;
        }
    }

}