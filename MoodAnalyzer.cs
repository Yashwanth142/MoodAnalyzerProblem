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
        public MoodAnalyser1()
        {
            this.msg = "SAD";
        }
        public MoodAnalyser1(string msg1)
        {
            this.msg = msg1;

        }

        public string analyseMood1()
        {
            MoodAnalyser1 obja = new MoodAnalyser1();
            return obja.msg;

        }
    }
}
