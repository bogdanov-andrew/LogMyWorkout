using System;
using System.Collections.Generic;
using System.Text;

namespace LogMyWorkout.XF
{
    public interface IExerciseEntity
    {
        string Name { get; set; }
        int Id { get; set; }
    }
}
