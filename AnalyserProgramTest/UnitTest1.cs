using AnalyserProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyzerProblemTest
{
    [TestClass]
    public class UnitTest1
    {
        //TC 5.1 : Given MoodAnalyser class name should return MoodAnalyser object
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            string message = null;
            MoodAnalyser expected = new MoodAnalyser(message);
            object resultObj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerApp.MoodAnalyser", "MoodAnalyser");
            Assert.AreEqual(expected.GetType(), resultObj.GetType());
        }

        //TC 5.2 : Given Improper class name should throw MoodAnaliserException.
        [TestMethod]
        public void GivenImproperClassNameShouldThrowException()
        {
            string excepted = "Class not found";
            try
            {
                object moodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerApp.DemoClass", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(excepted, exception.Message);
            }
        }
        //TC 5.3 : Given improper constructor should throw MoodAnalyserException.
        [TestMethod]
        public void GivenImproperConstructorShouldThrowException()
        {
            string excepted = "Constructor is not found";
            try
            {
                object moodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerApp.MoodAnalyser", "InvalidConstructor");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(excepted, exception.Message);
            }
        }
       
       
    }
}
