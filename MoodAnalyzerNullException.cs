using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerNullException : Exception
    {
        public MoodAnalyzerNullException(string msg) : base(msg)
        {

        }
    }
}
