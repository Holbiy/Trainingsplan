using System.Collections.Generic;
using System.Linq;
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
			return _context.TrainingPlans.SingleOrDefault(trainingPlan => trainingPlan.Id == id);
		}

		public void DeleteTrainingPlan(TrainingPlan trainingPlan)
		{
			_context.Remove(trainingPlan);
			_context.SaveChanges();
		}

		public void SaveTrainingPlan(TrainingPlan trainingPlan)
		{
			_context.Add(trainingPlan);
			_context.SaveChanges();
		}

		public void EditTrainingPlan(TrainingPlan trainingPlan)
		{
			throw new System.NotImplementedException();
		}
	}
}