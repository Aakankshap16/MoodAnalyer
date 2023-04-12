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
    
        public MoodAnalyser(string message)
        {
            this.message = message; 
        }    
        public string AnalyseMood()
        {
            try
            
            {
                if (string.IsNullOrEmpty(message))  // if empty goes directly to custom exception
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.Entered_Empty,"Mood should not be empty");
                }
                if (message.ToLower().Contains("sad"))
                {
                    return "Sad Mood";
                }
                else
                {
                    return "Happy Mood";
                }
            }
            catch(NullReferenceException)// if null handel under catch by custom exception 
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.Entered_Null, "Mood should not be  null");
            }

        }
    }
}
