using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserProgram
{
    public class MoodAnalyserCustomException: Exception
    {
        public enum ExceptionType
        {
           Entered_Null, Entered_Empty , No_Such_Field , No_Such_Method,
           No_Such_Class, Object_Creation_Issue
        }
        private ExceptionType type ;
        public MoodAnalyserCustomException(ExceptionType Type, string message):base(message) 
        {
                      this.type = Type;
        }
    }
}
