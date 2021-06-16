using System.Collections.Generic;
using TrainingsPlanApplikation.Models.Domain;

namespace TrainingsPlanApplikation.DataAccess
{
	public interface ITrainingPlanRepository
	{
		IEnumerable<TrainingPlan> GetAllTrainingPlans();

		TrainingPlan GetTrainingPlanById(int id);

		void DeleteTrainingPlan(TrainingPlan trainingPlan);

		void SaveTrainingPlan(TrainingPlan trainingPlan);

		void UpdateTrainingPlan(TrainingPlan trainingPlan);

	}
}