using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonLayer;

namespace BusinessLogic
{
    public static class BusinessLogicLayer
    {
        public static float CalculateAverageGrade(string key)
        {
            object result = CacheService.Get(key) as string;

            if (CacheService.Get(key) == null)
            {
                result = DataAccess.DataAccessLayer.CalculateAverageGrade(key);
                CacheService.Set(key, result);
            }
            return float.Parse(result.ToString());
        }

        public static bool UpdateStudentGrade(string studentID, int grade)
        {
            var result = DataAccess.DataAccessLayer.UpdateStudentGrade(studentID, grade);

            // If the grade was succesfully changed, then flush the cache
            if (result)
            {
                // Deletes the average result from cache
                CacheService.Remove("average");
            }

            return result;
        }
    }
}
