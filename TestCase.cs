using ModeAnalyzer;
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
        public void UseCase3_1()
        {
            try
            {
               string input = null;
               var analyze = new MoodAnalyser1(input);
            }
            catch (NullReferenceException Exception)
            {
                Assert.AreEqual("Mood can not be Null.", Exception.Message);
            }
        }
        
         [TestMethod]
        public void UseCase3_2()
        {
            try
            {
                var analyze = new MoodAnalyser("");
                string Returned_Message = analyze.analyseMood1();
                Assert.AreEqual("HAPPY", Returned_Message);
            }
            catch (MoodAnalyzerNullException Exception)
            {
                Assert.AreEqual("Mood can not be Empty.", Exception.Message);
            }

    }
}
