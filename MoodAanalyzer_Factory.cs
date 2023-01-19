using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Threading.Tasks;
using ModeAnalyzerAssignment;

namespace MoodAnalyzer
{
    
    public class Mood_Aanalyzer_Factory
    {
        public static object CreateMoodAnalyze(string className, string constructorName)
        {                     
            
            if (className.Equals(constructorName))
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyzeType = assembly.GetType(className);
                    return Activator.CreateInstance(moodAnalyzeType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzerNullException(MoodAnalyzerNullException.Exception_Type.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new MoodAnalyzerNullException(MoodAnalyzerNullException.Exception_Type.NO_SUCH_CONSTRUCTOR, "Constructor not found");
            }
        }
    }
}
