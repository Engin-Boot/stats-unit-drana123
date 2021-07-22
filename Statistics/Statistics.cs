using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public StatsDataModel CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            StatsDataModel result = new StatsDataModel();
            if (numbers.Capacity == 0)
                return  result;
            
            float average = 0;
            float min = float.MaxValue;
            float max = float.MinValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] > max){
                    max = numbers[i];
                }
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
                average += numbers[i];
               
            }
            average = average / numbers.Count;
            result.average = average;
            result.max = max;
            result.min = min;
            return result;
        }
    }
}
