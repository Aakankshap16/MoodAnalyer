using AnalyserProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyzerProblemTest
{
    [TestClass]
    public class UnitTest1
    {
        // TC 4.1 : Given MoodAnalyse class name should return MoodAnalyser object.
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyserObject()
        {
            object expected = new MoodAnalyser(null);
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("AnalyserProgram.MoodAnalyser", "MoodAnalyser");
            Assert.AreEqual(expected.GetType(), obj.GetType());
        }

        //TC 4.2 : Given Improper class name should throw MoodAnaliserException.
        [TestMethod]
        public void GivenImproperClassName_ShouldThrowMoodAnalyserException()
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

        //TC 4.3 : Given improper constructor should throw MoodAnalyserException.
        [TestMethod]
        public void GivenImproperConstructor_ShouldThrowMoodAnalyserException()
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

