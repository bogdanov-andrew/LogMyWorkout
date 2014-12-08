using System;
using System.Collections.Generic;
using System.Text;

namespace LogMyWorkout.XF
{
    public class ExerciseEntity : IExerciseEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
