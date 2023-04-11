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
    
        public MoodAnalyser() //DEAFULT
        {

        }
        public MoodAnalyser(string message) //PARAMERTEIZED
        {
            this.message = message; 
        }    
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
