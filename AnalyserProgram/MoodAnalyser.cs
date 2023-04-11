using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserProgram
{
    public class MoodAnalyser
    {
        private string message;
    
        public MoodAnalyser() 
        {

        }
        public MoodAnalyser(string message)
        {
            this.message = message; 
        }    
        public string AnalyseMood()
        {
            try
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
            catch
            {
                return "Happy Mood"; 
            }

        }
    }
}
