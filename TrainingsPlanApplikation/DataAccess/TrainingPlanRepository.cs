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

		public void SaveTrainingPlan(TrainingPlan trainingPlan)
		{
			_context.Add(trainingPlan);
			_context.SaveChanges();
		}

		public void UpdateTrainingPlan(TrainingPlan trainingPlan)
        {
            var newTrainingsPlan = _context.TrainingPlans.SingleOrDefault(t => t.Id == trainingPlan.Id);

            newTrainingsPlan.Exercises = trainingPlan.Exercises;
            newTrainingsPlan.Description = trainingPlan.Description;
            newTrainingsPlan.Title = trainingPlan.Title;

            _context.SaveChanges();
        }

	}
}