using MoodAnalyzer;
using System.Diagnostics.SymbolStore;
namespace TestCaseMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase1_1()
        {
            string input = "I am in Sad Mood";
            string expected = "SAD";


            MoodAnalyzer1 moodAnalyzer = new MoodAnalyzer1();

            string actual = moodAnalyzer.analyseMood(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase1_2()
        {
            string input = "I am in Any Mood";
            string expected = "HAPPY";


            MoodAnalyzer1 moodAnalyzer = new MoodAnalyzer1();

            string actual = moodAnalyzer.analyseMood(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Refactor1_1()
        {
            string input = "I am in Sad Mood";
            string expected = "SAD";


            MoodAnalyser1 moodAnalyser = new MoodAnalyser1();

            string actual = moodAnalyser.msg;

            Assert.AreEqual(expected, actual);
        }
    }

}
    
