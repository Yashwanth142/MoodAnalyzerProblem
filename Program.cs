namespace MoodAnalyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = "I am in Sad Mood";
            MoodAnalyzer1 moodAnalyzer1 = new MoodAnalyzer1();
            moodAnalyzer1.analyseMood(message);

            MoodAnalyser1  moodAnalyser = new MoodAnalyser1();
            string r2 = moodAnalyser.analyseMood1();

            string r1 = moodAnalyser.msg;
            Console.WriteLine(r2);

            Console.WriteLine(r1);
        }
    }
}