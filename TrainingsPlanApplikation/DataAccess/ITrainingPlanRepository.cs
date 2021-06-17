using System.Collections.Generic;
using TrainingsPlanApplikation.Models.Domain;

namespace TrainingsPlanApplikation.DataAccess
{
	public interface ITrainingPlanRepository
	{
		IEnumerable<TrainingPlan> GetAllTrainingPlans();

		TrainingPlan GetTrainingPlanById(int id);

		void DeleteTrainingPlan(TrainingPlan trainingPlan);

		void AddTrainingPlan(TrainingPlan trainingPlan);

		void UpdateTrainingPlan(TrainingPlan trainingPlan);

        void DeleteExerciseById(int id);

        void AddExerciseToTrainingPlan(int trainingPlanId, Exercise exercise);

    }
}