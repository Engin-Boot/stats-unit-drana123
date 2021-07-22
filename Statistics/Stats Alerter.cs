using System.Collections.Generic;


namespace Statistics
{
    public class StatsAlerter
    {
        float maxThreshold;
        IAlerter[] Allalerters;

        public StatsAlerter(float maxThreshold, IAlerter[] alerters)
        {
            this.maxThreshold = maxThreshold;
            this.Allalerters = alerters;
        }

        public void checkAndAlert(List<float> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > maxThreshold)
                {
                    for (int j = 0; j < Allalerters.Length; ++j)
                    {
                        Allalerters[j].Alert();
                    }
                    break;
                }
            }
        }
    }
}