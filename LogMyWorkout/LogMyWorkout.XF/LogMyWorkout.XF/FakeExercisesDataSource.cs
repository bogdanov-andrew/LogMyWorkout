using System;
using System.Collections.Generic;
using System.Text;

namespace LogMyWorkout.XF
{
    public class FakeExercisesDataSource : IExerciseDataSource
    {
        public IList<IExerciseEntity> GetAvaliableExercises()
        {
            var list = new List<IExerciseEntity>();

            list.Add(new ExerciseEntity() {Name =  "Exercise1", Id = 1});
            list.Add(new ExerciseEntity() { Name = "Exercise2", Id = 2 });
            list.Add(new ExerciseEntity() { Name = "Exercise3", Id = 3 });
            list.Add(new ExerciseEntity() { Name = "Exercise4", Id = 4 });
            list.Add(new ExerciseEntity() { Name = "Exercise5", Id = 5 });
            list.Add(new ExerciseEntity() { Name = "Exercise6", Id = 6 });

            return list;
        }
    }
}
