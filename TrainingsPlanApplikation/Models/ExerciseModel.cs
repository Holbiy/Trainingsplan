using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace TrainingsPlanApplikation.Models
{
    public class ExerciseModel
    {
        [Required]
        [StringLength(15)]
        [DisplayName("Titel")]
        public string Title { get; set; }
        
        [Required]
        [StringLength(50)]
        [DisplayName("Beschreibung")]
        public string Description { get; set; }
        
        [Required]
        [Range(1, 15)]
        [DisplayName("Anzahl Wiederholungen")]
        public int Reps { get; set; }
        
        [Required]
        [DisplayName("Bild")]
        public byte[] Image { get; set; }
    }
}