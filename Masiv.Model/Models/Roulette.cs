namespace Masiv.Model.Models
{
    public class Roulette
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string State { get { return Active ? "Activa" : "Inactiva"; } }
    }
}