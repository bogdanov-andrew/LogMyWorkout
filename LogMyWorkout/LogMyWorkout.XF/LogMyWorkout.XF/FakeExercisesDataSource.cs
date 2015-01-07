using System;
using System.Collections.Generic;
using System.Text;

namespace LogMyWorkout.XF
{
    public class FakeExercisesDataSource : IExerciseDataSource
    {
        List<IExerciseEntity> _list = new List<IExerciseEntity>();

        public FakeExercisesDataSource()
        {
            InitExerciseList();
        }

        private void InitExerciseList()
        {
            _list.Add(new ExerciseEntity() {Name = "Exercise1", Id = 1});
            _list.Add(new ExerciseEntity() {Name = "Exercise2", Id = 2});
            _list.Add(new ExerciseEntity() {Name = "Exercise3", Id = 3});
            _list.Add(new ExerciseEntity() {Name = "Exercise4", Id = 4});
            _list.Add(new ExerciseEntity() {Name = "Exercise5", Id = 5});
            _list.Add(new ExerciseEntity() {Name = "Exercise6", Id = 6});
        }

        public IList<IExerciseEntity> GetAvaliableExercises()
        {
            return _list;
        }

        public void AddExercise(IExerciseEntity entity)
        {
            _list.Add(entity);
        }
    }
}
