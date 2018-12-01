using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics(); 

            float sum = 0;
            foreach (float grade in grades)
            {
                // ----
                // if (grade > stats.HighestGrade)
                // {
                //     stats.HighestGrade = grade;
                // }
                // ----
                // Use above or belowz

                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrade(float _grade)
        {
            grades.Add(_grade);
        }

        public string Name;

        private List<float> grades;
    }
}