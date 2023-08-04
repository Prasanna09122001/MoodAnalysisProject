namespace MoodAnalysisProject
{
    public class MoodAnalyser
    {
        public string AnalayseMood(string Message)
        {
            if (Message.Contains("Sad"))
                return "SAD";
            else
                return "HAPPY";
        }

    }
}