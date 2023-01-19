using ModeAnalyzerAssignment;
using System.Diagnostics.SymbolStore;

namespace TestCaseMoodAnalyzer
{
   
 [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void UseCase4_1()
        {
            object expected = new MoodAnalyzer1();
            object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze("ModeAnalyzerAssignment.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(returned);
        }
      
          [TestMethod]
        public void UseCase4_2()
        {
            try
            {
                object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze("ModeAnalyzerAssignment.Mood", "Mood");
            }
            catch (MoodAnalyzerNullException Exception)
            {
                Assert.AreEqual("Class not found", Exception.Message);
            }
        }
    
     [TestMethod]
        public void UseCase4_3()
        {
            try
            {
                object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze("ModeAnalyzerAssignment.MoodAnalyzer", "MoodAnalyz");
            }
            catch (MoodAnalyzerNullException Exception)
            {
                Assert.AreEqual("Constructor not found", Exception.Message);
            }
        }
    
    }
}
