using System.ComponentModel.DataAnnotations;

namespace Appli_Express_Voiture.Models
{
    public class Voiture
    {
        [Key]
        public int Id { get; set; }
        public string Marque{ get; set; }
        public string Modele { get; set; }

        public float PrixAchat { get; set; }

        public ICollection<Reparation>? Reparations { get; set; }
    }
}
