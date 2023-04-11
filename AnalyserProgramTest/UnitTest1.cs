using AnalyserProgram;

namespace MoodAnalyzerProblemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //ARRANGE
            string expectedop = "Sad Mood";
            string msg = "I am very sad ";
            MoodAnalyser check = new MoodAnalyser(msg);

            //ACT
            string result = check.AnalyseMood(msg);

            //ASSERT
            Assert.AreEqual(expectedop, result);
        }

        [TestMethod]
        public void GivenHappyMoodShouldReturnHAPPY()
        {
            //ARRANGE
            string expectedop = "Happy Mood";
            string msg = "I am very Happy ";
            MoodAnalyser check = new MoodAnalyser(msg);

            //ACT
            string result = check.AnalyseMood(msg);

            //ASSERT
            Assert.AreEqual(expectedop, result);
        }
    }
}