using System;
using Xunit;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var statsDataModel = statsComputer.CalculateStatistics(
                new List<float>{1.5f, 8.9f, 3.2f, 4.5f}); 
            float epsilon = 0.001F;
            Assert.True(Math.Abs(statsDataModel.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(statsDataModel.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(statsDataModel.min - 1.5) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var statsData = statsComputer.CalculateStatistics(
                new List<float>{});
            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
        }
        [Fact]
        public void RaisesAlertsIfMaxIsMoreThanThreshold()
        {
            var emailAlert = new EmailAlert();
            var ledAlert = new LEDAlert();
            IAlerter[] alerters = {emailAlert, ledAlert};

            const float maxThreshold = 10.2F;
            var statsAlerter = new StatsAlerter(maxThreshold, alerters);
            statsAlerter.checkAndAlert(new List<float>{0.2F, 11.9F, 4.3F, 8.5F});

            Assert.True(emailAlert.IsEmailSent);
            Assert.True(ledAlert.IsLedGlowing);
        }
    }
}
