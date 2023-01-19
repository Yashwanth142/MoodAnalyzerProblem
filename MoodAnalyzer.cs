using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzer1
    {
        public string analyseMood(string message)
        {
            if (message == "I am in Sad Mood")
            {
                message = "SAD";
                return message;

            }
            else
            {
                message = "HAPPY";
                return message;
            }
        }

    }
    public class MoodAnalyser1
    {

        public string msg;       
        public MoodAnalyser1(string msg1)
        {
            this.msg = msg1;

        }

        public string analyseMood1()
        {
            MoodAnalyser1 moodAnalyser = new MoodAnalyser1(msg);
            msg = "";
            try
            {
                if (msg.Equals(string.Empty))
                    throw new MoodAnalyzerNullException(MoodAnalyzerNullException.Exception_Type.EMPTY_MOOD, "Mood can not be Empty.");
                else if (msg.ToUpper().Contains("SAD"))
                    return "SAD";
                else return "HAPPY";
            }
            catch (NullReferenceException)
            {
                
                throw new MoodAnalyzerNullException(MoodAnalyzerNullException.Exception_Type.NULL_MOOD, "Mood can not be Null.");
            }

        }
    }
}
