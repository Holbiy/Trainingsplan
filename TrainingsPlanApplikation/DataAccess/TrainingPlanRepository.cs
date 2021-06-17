using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TrainingsPlanApplikation.Models.Domain;

namespace TrainingsPlanApplikation.DataAccess
{
	public class TrainingPlanRepository : ITrainingPlanRepository
	{
		private readonly TrainingsPlanContext _context;

		public TrainingPlanRepository(TrainingsPlanContext context)
		{
			_context = context;
		}
		
		public IEnumerable<TrainingPlan> GetAllTrainingPlans()
		{
			return _context.TrainingPlans;
		}

		public TrainingPlan GetTrainingPlanById(int id)
		{
			return _context.TrainingPlans.Include(t => t.Exercises).SingleOrDefault(trainingPlan => trainingPlan.Id == id);
		}

		public void DeleteTrainingPlan(TrainingPlan trainingPlan)
		{
			_context.Remove(trainingPlan);
            foreach (var exercise in trainingPlan.Exercises.ToList())
                _context.Exercises.Remove(exercise);

            _context.SaveChanges();
        }

		public void AddTrainingPlan(TrainingPlan trainingPlan)
		{
			_context.Add(trainingPlan);
			_context.SaveChanges();
		}

		public void UpdateTrainingPlan(TrainingPlan newTrainingPlan)
        {
            var oldTrainingsPlan = GetTrainingPlanById(newTrainingPlan.Id);

            oldTrainingsPlan.Description = newTrainingPlan.Description;
            _context.SaveChanges();
        }

        public void DeleteExerciseById(int id)
        {
            var exercise = _context.Exercises.SingleOrDefault(x => x.Id == id);
            _context.Remove(exercise);
            _context.SaveChanges();
        }

        public void AddExerciseToTrainingPlan(int trainingPlanId, Exercise exercise)
        {
            var trainingPlan = GetTrainingPlanById(trainingPlanId);
			trainingPlan.Exercises.Add(exercise);
            _context.SaveChanges();
        }
    }
}