using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace TrainingsPlanApplikation.Models.Domain
{
    public class Exercise
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Titel muss angegeben werden")]
        [StringLength(15, ErrorMessage = "Titel darf nicht mehr als {1} Zeichen haben")]
        [DisplayName("Titel")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Beschreibung muss angegeben werden")]
        [StringLength(100, ErrorMessage = "Beschreibung darf maximal {1} Zeichen haben.")]
        [DisplayName("Beschreibung")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Anzahl Wiederholungen muss angegeben werden")]
        [Range(1, 15, ErrorMessage = "Anzahl Wiederholungen muss zwischen 1 und 15 sein")]
        [DisplayName("Anzahl Wiederholungen")]
        public int Reps { get; set; }
        
        //[DisplayName("Bild")]
        //public byte[]? Image { get; set; }
    }
}