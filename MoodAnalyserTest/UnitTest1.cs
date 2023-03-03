using MoodAnalyser;

namespace MoodAnalyserTest
{
    public class Tests
    {
        MoodAnalyzerProblem moodAnalyser = new MoodAnalyzerProblem();
        [Test]
        public void GivenSadMood_WhenAnalysed_ShouldReturnSad()
        {
            string result = moodAnalyser.AnalyseMood("I Am In Sad Mood.");
            Assert.AreEqual(result, "Sad");
        }
    }
}