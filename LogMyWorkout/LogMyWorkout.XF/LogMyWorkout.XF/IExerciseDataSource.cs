using System;
using System.Collections.Generic;
using System.Text;

namespace LogMyWorkout.XF
{
    public interface IExerciseDataSource
    {
        IList<IExerciseEntity> GetAvaliableExercises();
        void AddExercise(IExerciseEntity entity);
    }
}
