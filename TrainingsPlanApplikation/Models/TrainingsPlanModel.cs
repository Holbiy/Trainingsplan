using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TrainingsPlanApplikation.Models;

namespace TrainingsPlanApplikation.Models
{
    public class TrainingsPlanModel
    {
        [Required]
        [StringLength(15)]
        [Display(Name = "Titel")]
        public string Title { get; set; }
        
        [Required]
        [StringLength(15)]
        [Display(Name = "Beschreibung")]
        public string Description { get; set; }

        public List<ExerciseModel> Exercises { get; set; } = new List<ExerciseModel>();
    }
}