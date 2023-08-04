using MoodAnalysisProject;

namespace MoodAnalysisTest
{
    public class Tests
    {
        MoodAnalyser analyser = new MoodAnalyser();
        [Test]
        public void GivenSadMessage_WhenAnalsyse_SholudReturnSad()
        {
            string message = "I am in Sad Mood";
            string actual = analyser.AnalayseMood(message);
            Assert.AreEqual(actual,"SAD");
        }
        [Test]
        public void GivenHappyMessage_WhenAnalsyse_SholudReturnSad()
        {
            string message = "I am in Happy Mood";
            string actual1 = analyser.AnalayseMood(message);
            Assert.AreEqual(actual1, "HAPPY");
        }
    }
}