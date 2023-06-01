using System.ComponentModel.DataAnnotations;

namespace Appli_Express_Voiture.Models
{
    public class Reparation

    {
        [Key]
        public int Id { get; set; }
        public string TypeIntervention { get; set; }
        public float  CoutIntervention{ get; set;}
       public int VoitureId { get; set; }
        public Voiture? Voiture { get; set; }
    }
}

