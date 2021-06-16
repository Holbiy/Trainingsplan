using TrainingsPlanApplikation.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingsPlanApplikation.DataAccess
{
    public static class DbInitializer
    {
        public static void Initialize(TrainingsPlanContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.TrainingPlans.Any())
            {
                return;   // DB has been seeded
            }

            var exercises = new Exercise[]
            {
                new Exercise(){Title = "Schulterdrücken", Description = "Gewichte heben mit Schulter", Reps = 12},
                new Exercise(){Title = "Beinpresse", Description = "Übung für die Beine", Reps = 11},
                new Exercise(){Title = "Liegestütze", Description = "Wichtig für den ganzen Körper", Reps = 10}
            };
            foreach (var exercise in exercises)
            {
                context.Exercises.Add(exercise);
            }
            context.SaveChanges();
            
            var trainingsPlans = new TrainingPlan[]
            {
                new TrainingPlan(){Title = "Schultern", Description = "Ein Trainingsplan um die Schultern zu trainieren.", Exercises = new List<Exercise>(){exercises[0]}},
                new TrainingPlan(){Title = "Beine", Description = "Ein Trainingsplan um die Beine zu trainieren", Exercises = new List<Exercise>(){exercises[1]}},
                new TrainingPlan(){Title = "Ganzkörper", Description = "Ein anstrengendes Training für den den ganzen Körper.", Exercises = new List<Exercise>(){exercises[2]}}
            };
            foreach (var trainingsPlan in trainingsPlans)
            {
                context.TrainingPlans.Add(trainingsPlan);
            }
            context.SaveChanges();
            
        }
    }
}