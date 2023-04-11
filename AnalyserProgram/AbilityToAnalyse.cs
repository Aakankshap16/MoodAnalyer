using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserProgram
{
   public class AbilityToAnalyse
    {
        public string AnalyseMood(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                return "Sad Mood";
            }
            else
            {
                return "Happy Mood";
            }

        }
    }
}
