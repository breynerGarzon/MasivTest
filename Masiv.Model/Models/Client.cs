using System.ComponentModel.DataAnnotations;

namespace Masiv.Model.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        [Required(ErrorMessage = "El nombre debe ser suministrado")]
        [MaxLength(100, ErrorMessage = "El nombre puede ser máximo de 100 carácteres")]
        public string ClientName { get; set; }
        [Required(ErrorMessage = "El apellido debe ser suministrado")]
        [MaxLength(100, ErrorMessage = "El apellido puede ser máximo de 100 carácteres")]
        public string ClientLastName { get; set; }
        [Required(ErrorMessage = "El valor del saldo o crédito debe ser suministrado")]
        public decimal ClientBalance { get; set; }
    }
}