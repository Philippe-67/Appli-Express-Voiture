namespace Appli_Express_Voiture.Models
{
    public class Reparation

    {
        public int Id { get; set; }
        public string TypeIntervention { get; set; }
        public string  CoutIntervention{ get; set;}
        public int VoitureId { get; set; }
        public Voiture? Voiture { get; set; }
    }
}
