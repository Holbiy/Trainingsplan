using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TrainingsPlanApplikation.Models.Domain;

namespace TrainingsPlanApplikation.Models.Domain
{
    public class TrainingPlan
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(15)]
        [Display(Name = "Titel")]
        public string Title { get; set; }
        
        [Required]
        [StringLength(100)]
        [Display(Name = "Beschreibung")]
        public string Description { get; set; }

        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}