using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Xml.Linq;

namespace AnalyserProgram
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
           
            string pattern = @"." + constructorName + @"\(\)$";
            Match result = Regex.Match(pattern, className);
            if (result.Success)
            {
                try
                {
                    Assembly execute = Assembly.GetExecutingAssembly();
                    Type checktype = execute.GetType(className);
                    return Activator.CreateInstance(checktype);
                }
                catch
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.No_Such_Class, "Class not found");

                }
            }
            else
            {
              
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.No_Such_Method, "Constructor is not found");

            }
        }
    }
}
