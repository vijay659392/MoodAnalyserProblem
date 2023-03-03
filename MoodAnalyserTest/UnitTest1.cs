using MoodAnalyser;

namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenSadMood_WhenAnalysed_ShouldReturnSad()
        {
            MoodAnalyzerProblem moodAnalyser = new MoodAnalyzerProblem("I Am In Sad Mood.");
            string result = moodAnalyser.AnalyseMood();
            Assert.AreEqual(result, "Sad");
        }

    }
}