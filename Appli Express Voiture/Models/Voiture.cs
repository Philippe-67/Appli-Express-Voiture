namespace Appli_Express_Voiture.Models
{
    public class Voiture
    {
        public int Id { get; set; }
        public string Marque{ get; set; }
        public string Modele { get; set; }

        public ICollection<Reparation> Reparation { get; set; }
    }
}
