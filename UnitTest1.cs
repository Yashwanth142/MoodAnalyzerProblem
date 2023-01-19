using ModeAnalyzer;
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
      
        
    }
}
